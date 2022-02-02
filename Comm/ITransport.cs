using System;

namespace AssessmentSysEng.Comm {
  /// <summary>
  /// <see cref="ITransport"/> defines the basic communication interface for a specific device.
  /// Implementations of <see cref="ITransport"/> would typically wrap underlying transport protocols like TCP, UDP, or serial ports.
  /// <see cref="ITransport"/> allows for a device driver to focus on the device protocol and not the mechanism for sending packets.
  /// </summary>
  public interface ITransport {
    /// <summary>
    /// <p>
    /// Connect returns when a connection to the endpoint has been established, or none could be.
    /// If the device is already connected, this method returns immediately.
    /// A <see cref="ConnectionFailedException"/> is thrown if a connection could not be established.
    /// </p>
    /// <p>
    /// Note that even with transport protocols that do not require a connection, like UDP, <see cref="BytesReceived"/>
    /// and <see cref="Write"/> still require a Connect-ed <see cref="ITransport"/> to function.
    /// </p>
    /// </summary>
    void Connect();
    /// <summary>
    /// <p>Writes b to an open connection.</p>
    ///
    /// <p>Write will throw a <see cref="NotConnectedException"/> if we are not connected to the device.</p>
    /// </summary>
    /// <param name="b">The bytes to write to the connection</param>
    /// <returns></returns>
    int Write(byte[] b);
    /// <summary>
    /// <p>Close will close any open connections and interrupts any blocked <see cref="Write"/> calls.</p>
    ///
    /// <p>Subsequent calls to Close are a no-op.</p>
    /// </summary>
    void Close();
    /// <summary>
    /// BytesReceived will fire when any data is received from the device. BytesReceived will not fire until
    /// after a successful <see cref="Connect"/> call.
    /// </summary>
    event BytesReceivedDelegate BytesReceived;
  }

  public delegate void BytesReceivedDelegate(byte[] b);
}
