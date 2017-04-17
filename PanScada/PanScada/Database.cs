using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanScada
{
    static class Database
    {
        public class ElementSVGModel
        {
            public int ElementTypeID;
            public int Type;
            public int? State;
            public string SVG;
        }
        public class ElementTypeModel
        {
            public int ID;
            public string Name;
            public string Comment;
            public int ShowType;
        }
        public class ElementModel
        {
            public int ID;
            public int TypeID;
            public int MnemoID;
            public int? SignalID;
            public int X;
            public int Y;
            public int? X2;
            public int? Y2;
            public string Text;
            public string Styles;
            public int Action;
        }
        public class MnemoModel
        {
            public int ID;
            public string Name;
            public string Comment;
            public string Styles;
        }
        public class SignalTypeModel
        {
            public int ID;
            public string Name;
        }
        public class SignalModel
        {
            public int ID;
            public int TypeID;
            public float? Value;
            public int DeviceID;

        }
        public class DeviceModel
        {
            public int ID;
            public string Name;
        }

        static public List<ElementSVGModel> ElementSVG; // It will not change
        static public List<ElementTypeModel> ElementType; // It will not change
        static public List<ElementModel> Element; // It will change (MnemoEditor)
        static public List<MnemoModel> Mnemo; // It will not (MnemoEditor)
        static public List<SignalTypeModel> SignalType; // It will not change
        static public List<SignalModel> Signal; // It will change (Agent)
        static public List<DeviceModel> Device; // It will not change
    }
}
