using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Classwork20200408_Event_Planning
{
    [Serializable]
    public class EventList
    {
        public List<Event> Events { get; set; } = new List<Event>();
        public EventList()
        {
        }
        public void AddEvent(Event e)
        {
            Events.Add(e);
        }
        public void RemoveAt(int index)
        {
            Events.RemoveAt(index);
        }
        public void Clear()
        {
            Events.Clear();
        }
        public void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(Events);
            File.WriteAllText("1.json", json);
        }
    }
}
