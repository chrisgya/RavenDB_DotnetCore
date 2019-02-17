using System.Threading.Tasks;
using RavenDB_DotNetCore_App.Models;

namespace RavenDB_DotNetCore_App.services
{
     public interface ITalkService
    {
        Task<TalkSummary[]> GetTalkSummaries(int page);
        Task<TalkSummary[]> SearchTalks(string search, int page);
        Task<TalkDetail> GetTalkDetail(string id);
        Task<SpeakerTalkStats[]> GetSpeakerTalkStats();
        Task<Speaker[]> GetSpeakers();
        Task<TagTalkStats[]> GetTagTalkStats();
        Task<(UpdatedTalk Talk, string Version)> GetTalkForEditing(string id);
        Task<Talk> CreateTalk(NewTalk talk);
        Task<Talk> UpdateTalk(string id, UpdatedTalk talk, string version);
        Task<bool> DeleteTalk(string id);
        Task<TalkSummary[]> GetTalksBySpeaker(string speaker, int show);
        Task<TalkSummary[]> GetTalksByTag(string tag, int show);
    }
}