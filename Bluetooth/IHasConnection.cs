namespace AssessmentSysEng.Bluetooth {
  public interface IHasConnection {
    /// <summary>
    /// ConnectionChanged fires when the connection status for this device has changed,
    /// e.g. when a phone is connected.
    /// </summary>
    event ConnectionChangedDelegate ConnectionChanged;
  }
  
  public delegate void ConnectionChangedDelegate(Connection last);

  /// <summary>
  /// Connection indicates whether a remote device is connected via Bluetooth to a device.
  /// </summary>
  public enum Connection {
    /// <summary>
    /// Unknown is used to indicate that we don't know the connection status.
    /// It should be used as a response under error conditions.
    /// </summary>
    Unknown,
    /// <summary>
    /// NotConnected indicates that no Bluetooth connection is active.
    /// </summary>
    NotConnected,
    /// <summary>
    /// Connected indicates that there is an active Bluetooth connection.
    /// </summary>
    Connected
  }
}
