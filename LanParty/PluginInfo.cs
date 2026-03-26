namespace LanParty;

internal static class PluginInfo
{
    public const string DisplayName = "LAN Party";
    public const string InternalName = "LanParty";
    public const string Command = "/lanparty";
    public const string Visibility = "Public";
    public const string Summary = "Cross-client daily roulette coordination scaffold.";
    public const string SupportUrl = "https://ko-fi.com/mcvaxius";
    public static readonly string[] Concept = new[]
    {
        "Each client reports its own state.",
        "Use localhost transport and explicit claims.",
        "Keep ownership and recovery explicit."
    };
    public static readonly string[] Services = new[]
    {
        "ConfigManager",
        "ILocalPeerTransport",
        "NamedPipePeerTransport",
        "PresenceService",
        "ClaimService",
        "ReadinessService",
        "RouletteScheduleService",
        "WorkerStateMachine"
    };
    public static readonly string[] Phases = new[]
    {
        "Shell and docs",
        "Presence transport",
        "Schedules and claims",
        "Dependency wrappers",
        "Real orchestration"
    };
    public static readonly string[] Tests = new[]
    {
        "Load plugin and open UI",
        "Confirm account and character profile creation",
        "Save profile notes"
    };
}
