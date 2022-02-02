namespace AssessmentSysEng.Bluetooth {
  /// <summary>
  /// IHasAnnounce provides functionality for triggering this device to activate the pairing flow.
  /// After calling Announce, this device should be discoverable by Bluetooth sources to connect to using their
  /// native Bluetooth pairing interfaces.
  /// </summary>
  public interface IHasAnnounce {
    void Announce();
  }
}
