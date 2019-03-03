using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GitProjectWebsite.Controllers
{
    public class Repository
    {
        private int _ID;
        private string _NodeID;
        private string _Name;
        private string _FullName;
        private bool _Private;
        private string _HTMLURL;
        private string _Description;
        private string _Fork;
        private string _URL;
        private string _ForksURL;
        private string _KeysURL;
        private string _CollaboratorsURL;
        private string _TeamsURL;
        private string _HooksURL;
        private string _IssueEventsURL;
        private string _EventsURL;
        private string _AssigneesURL;
        private string _BranchesURL;
        private string _TagsURL;
        private string _BlobsURL;
        private string _GitTagsURL;
        private string _GitRefsURL;
        private string _TreesURL;
        private string _StatusesURL;
        private string _LanguagesURL;
        private string _StarGazersURL;
        private string _ContributorsURL;
        private string _SubscribersURL;
        private string _SubscriptionURL;
        private string _CommitsURL;
        private string _GitCommitsURL;
        private string _CommentsURL;
        private string _IssueCommentsURL;
        private string _ContentsURL;
        private string _CompareURL;
        private string _MergesURL;
        private string _ArchiveURL;
        private string _DownloadsURL;
        private string _IssuesURL;
        private string _PullsURL;
        private string _MilestonesURL;
        private string _NotificationsURL;
        private string _LabelsURL;
        private string _ReleasesURL;
        private string _DeploymentsURL;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private DateTime _PushedAt;
        private string _GitURL;
        private string _SSHURL;
        private string _CloneURL;
        private string _SVNURL;
        private string _Homepage;
        private int _Size;
        private int _StargazersCount;
        private int _WatcherCount;
        private string _Language;
        private bool _HasIssues;
        private bool _HasProjects;
        private bool _HasDownloads;
        private bool _HasWiki;
        private bool _HasPages;
        private int _ForksCount;
        private string _MirrorURL;
        private bool _Archived;
        private int _OpenIssuesCount;
        private string _License;
        private int _Forks;
        private int _OpenIssues;
        private int _Watchers;
        private string _DefaultBranch;

        public Repository()
        {

        }
        [JsonProperty(PropertyName = "default_branch")]
        public string DefaultBranch
        {
            get { return _DefaultBranch; }
            set { _DefaultBranch = value; }
        }


        [JsonProperty(PropertyName = "watchers")]
        public int Watchers
        {
            get { return _Watchers; }
            set { _Watchers = value; }
        }

        [JsonProperty(PropertyName = "open_issues")]
        public int OpenIssues
        {
            get { return _OpenIssues; }
            set { _OpenIssues = value; }
        }

        [JsonProperty(PropertyName = "forks")]
        public int Forks
        {
            get { return _Forks; }
            set { _Forks = value; }
        }


        [JsonProperty(PropertyName = "license")]
        public string License
        {
            get { return _License; }
            set { _License = value; }
        }

        [JsonProperty(PropertyName = "open_issues_count")]
        public int OpenIssuesCount
        {
            get { return _OpenIssuesCount; }
            set { _OpenIssuesCount = value; }
        }

        [JsonProperty(PropertyName = "archived")]
        public bool Archived
        {
            get { return _Archived; }
            set { _Archived = value; }
        }


        [JsonProperty(PropertyName = "mirror_url")]
        public string MirrorURL
        {
            get { return _MirrorURL; }
            set { _MirrorURL = value; }
        }

        [JsonProperty(PropertyName = "forks_count")]
        public int ForksCount
        {
            get { return _ForksCount; }
            set { _ForksCount = value; }
        }

        [JsonProperty(PropertyName = "has_pages")]
        public bool HasPages
        {
            get { return _HasPages; }
            set { _HasPages = value; }
        }

        [JsonProperty(PropertyName = "has_wiki")]
        public bool HasWiki
        {
            get { return _HasWiki; }
            set { _HasWiki = value; }
        }

        [JsonProperty(PropertyName = "has_downloads")]
        public bool HasDownloads
        {
            get { return _HasDownloads; }
            set { _HasDownloads = value; }
        }


        [JsonProperty(PropertyName = "has_projects")]
        public bool HasProjects
        {
            get { return _HasProjects; }
            set { _HasProjects = value; }
        }

        [JsonProperty(PropertyName = "has_issues")]
        public bool HasIssues
        {
            get { return _HasIssues; }
            set { _HasIssues = value; }
        }


        [JsonProperty(PropertyName = "language")]
        public string Language
        {
            get { return _Language; }
            set { _Language = value; }
        }


        [JsonProperty(PropertyName = "watcher_count")]
        public int WatcherCount
        {
            get { return _WatcherCount; }
            set { _WatcherCount = value; }
        }

        [JsonProperty(PropertyName = "stargazers_count")]
        public int StargazersCount
        {
            get { return _StargazersCount; }
            set { _StargazersCount = value; }
        }

        [JsonProperty(PropertyName = "size")]
        public int Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        [JsonProperty(PropertyName = "homepage")]
        public string Homepage
        {
            get { return _Homepage; }
            set { _Homepage = value; }
        }

        [JsonProperty(PropertyName = "svn_url")]
        public string SVNURL
        {
            get { return _SVNURL; }
            set { _SVNURL = value; }
        }

        [JsonProperty(PropertyName = "clone_url")]
        public string CloneURL
        {
            get { return _CloneURL; }
            set { _CloneURL = value; }
        }

        [JsonProperty(PropertyName = "ssh_url")]
        public string SSHURL
        {
            get { return _SSHURL; }
            set { _SSHURL = value; }
        }

        [JsonProperty(PropertyName = "git_url")]
        public string GitURL
        {
            get { return _GitURL; }
            set { _GitURL = value; }
        }

        [JsonProperty(PropertyName = "pushed_at")]
        public DateTime PushedAt
        {
            get { return _PushedAt; }
            set { _PushedAt = value; }
        }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt
        {
            get { return _UpdatedAt; }
            set { _UpdatedAt = value; }
        }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt
        {
            get { return _CreatedAt; }
            set { _CreatedAt = value; }
        }

        [JsonProperty(PropertyName = "deployments_url")]
        public string DeploymentsURL
        {
            get { return _DeploymentsURL; }
            set { _DeploymentsURL = value; }
        }

        [JsonProperty(PropertyName = "releases_url")]
        public string ReleasesURL
        {
            get { return _ReleasesURL; }
            set { _ReleasesURL = value; }
        }

        [JsonProperty(PropertyName = "labels_url")]
        public string LabelsURL
        {
            get { return _LabelsURL; }
            set { _LabelsURL = value; }
        }

        [JsonProperty(PropertyName = "notificationS_url")]
        public string NotificationsURL
        {
            get { return _NotificationsURL; }
            set { _NotificationsURL = value; }
        }

        [JsonProperty(PropertyName = "milestones_url")]
        public string MilestonesURL
        {
            get { return _MilestonesURL; }
            set { _MilestonesURL = value; }
        }

        [JsonProperty(PropertyName = "pulls_url")]
        public string PullsURL
        {
            get { return _PullsURL; }
            set { _PullsURL = value; }
        }


        [JsonProperty(PropertyName = "issues_url")]
        public string IssuesURL
        {
            get { return _IssuesURL; }
            set { _IssuesURL = value; }
        }

        [JsonProperty(PropertyName ="downloads_url")]
        public string DownloadsURL
        {
            get { return _DownloadsURL; }
            set { _DownloadsURL = value; }
        }

        [JsonProperty(PropertyName = "archive_url")]
        public string ArchiveURL
        {
            get { return _ArchiveURL; }
            set { _ArchiveURL = value; }
        }

        [JsonProperty(PropertyName = "merges_url")]
        public string MergesURL
        {
            get { return _MergesURL; }
            set { _MergesURL = value; }
        }

        [JsonProperty(PropertyName = "compare_url")]
        public string CompareURL
        {
            get { return _CompareURL; }
            set { _CompareURL = value; }
        }

        [JsonProperty(PropertyName = "contents_url")]
        public string ContentsURL
        {
            get { return _ContentsURL; }
            set { _ContentsURL = value; }
        }

        [JsonProperty(PropertyName = "issue_comment_url")]
        public string IssueCommentsURL
        {
            get { return _IssueCommentsURL; }
            set { _IssueCommentsURL = value; }
        }

        [JsonProperty(PropertyName = "comments_url")]
        public string CommentsURL
        {
            get { return _CommentsURL; }
            set { _CommentsURL = value; }
        }

        [JsonProperty(PropertyName = "git_commits_url")]
        public string GitCommitsURL
        {
            get { return _GitCommitsURL; }
            set { _GitCommitsURL = value; }
        }

        [JsonProperty(PropertyName ="commits_url")]
        public string CommitsURL
        {
            get { return _CommitsURL; }
            set { _CommitsURL = value; }
        }

        [JsonProperty(PropertyName = "subscription_url")]
        public string SubscriptionURL
        {
            get { return _SubscriptionURL; }
            set { _SubscriptionURL = value; }
        }

        [JsonProperty(PropertyName = "subscribers_url")]
        public string SubscribersURL
        {
            get { return _SubscribersURL; }
            set { _SubscribersURL = value; }
        }

        [JsonProperty(PropertyName = "contributors_url")]
        public string ContributorsURL
        {
            get { return _ContributorsURL; }
            set { _ContributorsURL = value; }
        }

        [JsonProperty(PropertyName = "stargazers_url")]
        public string StarGazersURL
        {
            get { return _StarGazersURL; }
            set { _StarGazersURL = value; }
        }

        [JsonProperty(PropertyName = "languages_url")]
        public string LanguagesURL
        {
            get { return _LanguagesURL; }
            set { _LanguagesURL = value; }
        }

        [JsonProperty(PropertyName = "statuses_url")]
        public string StatusesURL
        {
            get { return _StatusesURL; }
            set { _StatusesURL = value; }
        }

        [JsonProperty(PropertyName ="trees_url")]
        public string TreesURL
        {
            get { return _TreesURL; }
            set { _TreesURL = value; }
        }

        [JsonProperty(PropertyName ="git_refs_url")]
        public string GitRefsURL
        {
            get { return _GitRefsURL; }
            set { _GitRefsURL = value; }
        }

        [JsonProperty(PropertyName ="git_tags_url")]
        public string GitTagsURL
        {
            get { return _GitTagsURL; }
            set { _GitTagsURL = value; }
        }

        [JsonProperty(PropertyName ="blobs_url")]
        public string BlobsURL
        {
            get { return _BlobsURL; }
            set { _BlobsURL = value; }
        }

        [JsonProperty(PropertyName = "tags_url")]
        public string TagsURL
        {
            get { return _TagsURL; }
            set { _TagsURL = value; }
        }

        [JsonProperty(PropertyName ="branches_url")]
        public string BranchesURL
        {
            get { return _BranchesURL; }
            set { _BranchesURL = value; }
        }

        [JsonProperty(PropertyName = "assignees_url")]
        public string AssigneesURL
        {
            get { return _AssigneesURL; }
            set { _AssigneesURL = value; }
        }

        [JsonProperty(PropertyName ="events_url")]
        public string EventsURL
        {
            get { return _EventsURL; }
            set { _EventsURL = value; }
        }


        [JsonProperty(PropertyName ="issue_event_url")]
        public string IssueEventsURL
        {
            get { return _IssueEventsURL; }
            set { _IssueEventsURL = value; }
        }

        [JsonProperty(PropertyName = "hooks_url")]
        public string HooksURL
        {
            get { return _HooksURL; }
            set { _HooksURL = value; }
        }

        [JsonProperty(PropertyName = "teams_url")]
        public string TeamsURL
        {
            get { return _TeamsURL; }
            set { _TeamsURL = value; }
        }

        [JsonProperty(PropertyName ="collaborators_url")]
        public string CollaboratorsURL
        {
            get { return _CollaboratorsURL; }
            set { _CollaboratorsURL = value; }
        }

        [JsonProperty(PropertyName = "keys_url")]
        public string KeysURL
        {
            get { return _KeysURL; }
            set { _KeysURL = value; }
        }

        [JsonProperty(PropertyName ="forks_url")]
        public string ForksURL
        {
            get { return _ForksURL; }
            set { _ForksURL = value; }
        }

        [JsonProperty(PropertyName ="url")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

        [JsonProperty(PropertyName ="fork")]
        public string Fork
        {
            get { return _Fork; }
            set { _Fork = value; }
        }


        [JsonProperty(PropertyName ="description")]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [JsonProperty(PropertyName ="html_url")]
        public string HTMLURL
        {
            get { return _HTMLURL; }
            set { _HTMLURL = value; }
        }


        [JsonProperty(PropertyName = "private")]
        public bool Private
        {
            get { return _Private; }
            set { _Private = value; }
        }

        [JsonProperty(PropertyName ="full_name")]
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        [JsonProperty(PropertyName ="name")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [JsonProperty(PropertyName ="node_id")]
        public string NodeID
        {
            get { return _NodeID; }
            set { _NodeID = value; }
        }

        [JsonProperty(PropertyName ="id")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

    }
}