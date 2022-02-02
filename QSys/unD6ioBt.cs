using AssessmentSysEng.Comm;

namespace AssessmentSysEng.QSys {
  /// <summary>
  /// <see cref="unD6ioBt"/> implements interrogation and control of a Q-SYS unD6IO-BT device.
  /// </summary>
  // ReSharper disable once InconsistentNaming
  public class unD6ioBt {
    /// <summary>
    /// <see cref="transport"/> abstracts the underlying transport communication with the device.
    /// We can assume that the underlying implementation of <see cref="transport"/>
    /// is compatible with our device model.
    /// </summary>
    private readonly ITransport transport;

    public unD6ioBt(ITransport transport) {
      this.transport = transport;
    }
  }
}
