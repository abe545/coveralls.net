using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DocoptNet;

namespace csmacnz.Coveralls
{
    // Generated class for Main.usage.txt
    [SuppressMessage("ReSharper", "MergeConditionalExpression")]
    [SuppressMessage("ReSharper", "ConvertPropertyToExpressionBody")]
    public class MainArgs
    {
        public const string Usage = @"csmacnz.Coveralls - a coveralls.io coverage publisher for .Net

Usage:
  csmacnz.Coveralls (--opencover | --dynamiccodecoverage | --monocov | --exportcodecoverage | --chutzpah | --lcov | --multiple) -i ./opencovertests.xml (--repoToken <repoToken> | [--repoTokenVariable <repoTokenVariable>]) [-o ./opencovertests.json] [--dryrun] [--useRelativePaths [--basePath <path>] ] [--commitId <commitId> --commitBranch <commitBranch> [--commitAuthor <commitAuthor> --commitEmail <commitEmail> --commitMessage <commitMessage>] ] [--jobId <jobId>] [--serviceName <Name>] [--serviceNumber <Number>] [--pullRequest <pullRequestId>] [--treatUploadErrorsAsWarnings] [--parallel]
  csmacnz.Coveralls --version
  csmacnz.Coveralls --help

Options:
 -h, --help                               Show this screen.
 --version                                Show version.
 -i <file>, --input <file>                The coverage source file location. When --aggregate is used, this is a collection of inputs to publish together. The format is ""monocov=coverage.cov;chutzpah=chutzpah.json""
 -o <file>, --output <file>               The coverage results json will be written to this file if provided.
 --dryrun                                 This flag will stop coverage results being posted to coveralls.io
 --useRelativePaths                       This flag, when provided, will attempt to strip the current working directory from the beginning of the source file path.
 --basePath <path>                        When useRelativePaths and a basePath is provided, this path is used instead of the current working directory.
 --opencover                              Reads input as OpenCover data.
 --dynamiccodecoverage                    Reads input as the CodeCoverage.exe xml format.
 --exportcodecoverage                     Reads input as the Visual Studio Coverage Export xml format
 --monocov                                Reads input as monocov results folder.
 --chutzpah                               Reads input as chutzpah json data.
 --lcov									  Reads input as lcov format.
 --multiple                               Provide multiple types and files. This mode requires -i to provide values in the format ""chutzpah=chutzpahFile.json;opencover=opencoverFile.xml""
 --parallel                               If using the parallel builds. If sent, it will wait for the webhook before completing the build.
 --repoToken <repoToken>                  The coveralls.io repository token.
 --repoTokenVariable <repoTokenVariable>  The Environment Variable name where the coveralls.io repository token is available. [default: COVERALLS_REPO_TOKEN]
 --commitId <commitId>                    The git commit hash for the coverage report.
 --commitBranch <commitBranch>            The git branch for the coverage report.
 --commitAuthor <commitAuthor>            The git commit author for the coverage report.
 --commitEmail <commitEmail>              The git commit author email for the coverage report.
 --commitMessage <commitMessage>          The git commit message for the coverage report.
 --jobId <jobId>                          The job Id to provide to coveralls.io. [default: 0]
 --serviceName <Name>                     The service-name for the coverage report. [default: coveralls.net]
 --serviceNumber <Number>                 The service-number for the coverage report.
 --pullRequest <pullRequestId>            The github pull request id. Used for updating status on github PRs.
 -k, --treatUploadErrorsAsWarnings        Exit successfully if an upload error is encountered and this flag is set.

Commit Options:
  If --commitId and --commitBranch are provided, all git settings will come from the command line arguments.
  If you do not provide any commit information, the correct information will be resolved for you using the following logic:
    * If you are on AppVeyor build server ($env:APPVEYOR -eq $true) We will locate the data from the Environment Variables.
    * If git is available in the current working directory, the settings will be loaded from git.


What it's for:
 Reads your .Net code coverage output data and submits it to
 coveralls.io's service. This can be used by your build scripts
 or with a CI builder server.";

        public MainArgs(
            ICollection<string> argv,
            bool help = true,
            object version = null,
            bool optionsFirst = false,
            bool exit = false)
        {
            Args = new Docopt().Apply(Usage, argv, help, version, optionsFirst, exit);
        }

        public IDictionary<string, ValueObject> Args { get; }

        public bool IsProvided(string parameter)
        {
            return Args[parameter] != null;
        }

		public bool OptOpencover { get { return Args["--opencover"].IsTrue; } }
		public bool OptDynamiccodecoverage { get { return Args["--dynamiccodecoverage"].IsTrue; } }
		public bool OptMonocov { get { return Args["--monocov"].IsTrue; } }
		public bool OptExportcodecoverage { get { return Args["--exportcodecoverage"].IsTrue; } }
		public bool OptChutzpah { get { return Args["--chutzpah"].IsTrue; } }
		public bool OptLcov { get { return Args["--lcov"].IsTrue; } }
		public bool OptMultiple { get { return Args["--multiple"].IsTrue; } }
		public string OptInput { get { return null == Args["--input"] ? null : Args["--input"].ToString(); } }
		public string OptRepotoken { get { return null == Args["--repoToken"] ? null : Args["--repoToken"].ToString(); } }
		public string OptRepotokenvariable { get { return null == Args["--repoTokenVariable"] ? null : Args["--repoTokenVariable"].ToString(); } }
		public string OptOutput { get { return null == Args["--output"] ? null : Args["--output"].ToString(); } }
		public bool OptDryrun { get { return Args["--dryrun"].IsTrue; } }
		public bool OptUserelativepaths { get { return Args["--useRelativePaths"].IsTrue; } }
		public string OptBasepath { get { return null == Args["--basePath"] ? null : Args["--basePath"].ToString(); } }
		public string OptCommitid { get { return null == Args["--commitId"] ? null : Args["--commitId"].ToString(); } }
		public string OptCommitbranch { get { return null == Args["--commitBranch"] ? null : Args["--commitBranch"].ToString(); } }
		public string OptCommitauthor { get { return null == Args["--commitAuthor"] ? null : Args["--commitAuthor"].ToString(); } }
		public string OptCommitemail { get { return null == Args["--commitEmail"] ? null : Args["--commitEmail"].ToString(); } }
		public string OptCommitmessage { get { return null == Args["--commitMessage"] ? null : Args["--commitMessage"].ToString(); } }
		public string OptJobid { get { return null == Args["--jobId"] ? null : Args["--jobId"].ToString(); } }
		public string OptServicename { get { return null == Args["--serviceName"] ? null : Args["--serviceName"].ToString(); } }
		public string OptServicenumber { get { return null == Args["--serviceNumber"] ? null : Args["--serviceNumber"].ToString(); } }
		public string OptPullrequest { get { return null == Args["--pullRequest"] ? null : Args["--pullRequest"].ToString(); } }
		public bool OptTreatuploaderrorsaswarnings { get { return Args["--treatUploadErrorsAsWarnings"].IsTrue; } }
		public bool OptParallel { get { return Args["--parallel"].IsTrue; } }
		public bool OptVersion { get { return Args["--version"].IsTrue; } }
		public bool OptHelp { get { return Args["--help"].IsTrue; } }
    }
}
