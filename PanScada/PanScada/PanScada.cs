using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanScada;
using System.IO;

namespace PanScada
{
    public class PanScada
    {
        public PanScada(string pathToConfigFile)
        {
            if (File.Exists(pathToConfigFile))
            {
                string cfile = File.ReadAllText(pathToConfigFile, Encoding.UTF8);

            }
        }
    }

    public class ConfigFileModel
    {
        public string mnemos;
        public string elementTypes;
        public string elementStates;
        public string signalTypes;
        public string devices;
    }
    public class MnemosModel
    {

    }
    public class ElementsModel
    {

    }
    public class ElementTypesModel
    {

    }
    public class ElementStatesModel
    {

    }
    public class SignalsModel
    {

    }
    //
}
