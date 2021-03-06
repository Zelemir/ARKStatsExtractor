﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ARKBreedingStats
{
    [Serializable()]
    public class TimerListEntry
    {
        public DateTime time;
        public string name;
        public string group;
        [XmlIgnore]
        public System.Windows.Forms.ListViewItem lvi;
        [XmlIgnore]
        public bool showInOverlay;
        [XmlIgnore]
        public Creature creature;
    }
}
