using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smash.gg;

namespace Smash.ggTests
{
    [TestClass]
    public class DeserialiseLinks
    {
        private readonly AsyncDataHelper _data;
        public DeserialiseLinks()
        {
            _data = new AsyncDataHelper();
        }

        [TestMethod]
        public void PhaseGroups()
        {
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/499362?expand[]=sets&expand[]=entrants");
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/499360?expand[]=sets&expand[]=entrants");
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/515049?expand[]=sets&expand[]=entrants");
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/515605?expand[]=sets&expand[]=entrants");
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/515606?expand[]=sets&expand[]=entrants");
            _data.Deserialize<PhaseGroup>("https://api.smash.gg/phase_group/533045?expand[]=sets&expand[]=entrants");
        }

        [TestMethod]
        public void EventGroup()
        {
            _data.Deserialize<EventGroup>("https://api.smash.gg/event/80373?expand[]=groups&expand[]=phase");
        }

        [TestMethod]
        public void TournamentGroup()
        {
            _data.Deserialize<TournamentGroup>("https://api.smash.gg/tournament/koopas-keep-dojo?expand[]=event&expand[]=phase&expand[]=groups&expand[]=stations");
        }
    }
}
