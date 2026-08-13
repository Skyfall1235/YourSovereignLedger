using System;

namespace YourSovereignLedger.Services;

public class PrivacyStateService
{
    public bool IsGlobalPrivacyActive { get; private set; } = true;

    public event Action? OnPrivacyStateChanged;

    public void TogglePrivacy()
    {
        IsGlobalPrivacyActive = !IsGlobalPrivacyActive;
        OnPrivacyStateChanged?.Invoke();
    }
}