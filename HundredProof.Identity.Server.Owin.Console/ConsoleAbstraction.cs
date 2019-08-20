// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleAbstraction.cs" company="HundredProof">
//    Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Server.Owin.Console
{
    using CLAP;
    using Its.Configuration;

    /// <summary>
    /// Abstraction layer for the console harness bootstrapper.
    /// </summary>
    public class ConsoleAbstraction : ConsoleAbstractionBase
    {
        /// <summary>
        /// Listen for requests.
        /// </summary>
        /// <param name="debug">Optional indication to launch the debugger from inside the application (default is false).</param>
        /// <param name="environment">Optional value to use when setting the Its.Configuration precedence to use specific settings.</param>
        [Verb(Aliases = nameof(WellKnownConsoleVerb.Listen), IsDefault = false, Description = "Runs the Self Host API Harness listening for web requests;\r\n            example usage: [Harness].exe listen\r\n                           [Harness].exe listen /debug=true\r\n                           [Harness].exe listen /environment=ExampleDevelopment\r\n                           [Harness].exe listen /environment=ExampleDevelopment /debug=true\r\n")]
        public static void Listen(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("env")] [Description("Sets the Its.Configuration precedence to use specific settings.")] [DefaultValue(null)] string environment)
        {
            /*---------------------------------------------------------------------------*
             * Any method should run this logic to debug, setup config & logging, etc.   *
             *---------------------------------------------------------------------------*/
            CommonSetup(debug, environment);

            /*---------------------------------------------------------------------------*
             * Any method should run this logic to write telemetry info to the log.      *
             *---------------------------------------------------------------------------*/
            WriteStandardTelemetry();

            /*---------------------------------------------------------------------------*
             * Necessary configuration.                                                *
             *---------------------------------------------------------------------------*/
            var harnessSettings = Settings.Get<HarnessSettings>();
            var hostingSettings = Settings.Get<HostingSettings>();
            var jwtAuthenticationSettings = Settings.Get<JwtAuthenticationSettings>();

            /*---------------------------------------------------------------------------*
             * Launch the harness here, it will run until the TimeToLive has expired AND *
             * there are no active messages being handled or if there is an internal     *
             * error.  Failed message handling is logged and does not crash the harness. *
             *---------------------------------------------------------------------------*/
            SelfHostHarnessManager.Launch(harnessSettings, hostingSettings, jwtAuthenticationSettings);
        }
    }
}