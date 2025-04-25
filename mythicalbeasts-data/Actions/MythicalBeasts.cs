using mythicalbeasts_data.DataModels;
using mythicalbeasts_data.Global;
using System.Collections.Immutable;

namespace mythicalbeasts_data.Actions
{
    public class MythicalBeasts
    {
        public List<MythicalBeast> GetAll()
        {
            var beasts = Global.MythicalBeasts.Current;
            return beasts;
        }

        public MythicalBeast Get(int id)
        {
            var beasts = Global.MythicalBeasts.Current;
            return beasts.First(x => x.Id == id);
        }
    }
}
