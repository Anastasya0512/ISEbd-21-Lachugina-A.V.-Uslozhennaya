﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBusUsl
{
    class AutovoksalCollection
    {
        readonly Dictionary<string, Autovoksal<EasyBus, RectangleForm>> autovoksalStages;

        public List<string> Keys => autovoksalStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AutovoksalCollection(int pictureWidth, int pictureHeight)
        {
            autovoksalStages = new Dictionary<string, Autovoksal<EasyBus, RectangleForm>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAutovoksal(string name)
        {
            if (autovoksalStages.ContainsKey(name))
            {
                return;
            }
            autovoksalStages.Add(name, new Autovoksal<EasyBus, RectangleForm>(pictureWidth, pictureHeight));
        }

        public void DelAutovoksal(string name)
        {
            if (autovoksalStages.ContainsKey(name))
            {
                autovoksalStages.Remove(name);
            }
        }

        public Autovoksal<EasyBus, RectangleForm> this[string index]
        {
            get
            {
                if (autovoksalStages.ContainsKey(index))
                {
                    return autovoksalStages[index];
                }
                else
                {
                    return null;
                }
            }
        }
        public EasyBus this[string key, int ind]
        {
            get
            {
                if (autovoksalStages.ContainsKey(key) && ind > -1)
                {
                    return autovoksalStages[key]._places[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"AutovoksalCollection");
                foreach (var level in autovoksalStages)
                {
                    sw.WriteLine($"Autovoksal{separator}{level.Key}");
                    ITransport bus = null;
                    for (int i = 0; (bus = level.Value.GetNext(i)) != null; i++)
                    {
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "Bus")
                            {
                                sw.Write($"Bus{separator}");
                            }
                            if (bus.GetType().Name == "BusGarm")
                            {
                                sw.Write($"BusGarm{separator}");
                            }
                            sw.WriteLine(bus);
                        }
                    }
                }
            }
        }
        public void SaveOneLevel(string filename, string autovoksalName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (autovoksalStages.ContainsKey(autovoksalName))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine($"OneAutovoksal");

                        sw.WriteLine($"Autovoksal{separator}{autovoksalName}");
                        ITransport bus = null;
                        var level = autovoksalStages[autovoksalName];

                        for (int i = 0; (bus = level[i]) != null; i++)
                        {
                            if (bus != null)
                            {
                                if (bus.GetType().Name == "Bus")
                                {
                                    sw.Write($"Bus{separator}");

                                }
                                if (bus.GetType().Name == "BusGarm")
                                {
                                    sw.Write($"BusGarm{separator}");
                                }
                                sw.WriteLine(bus);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        public void LoadData(string filename, bool loadType)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AutovoksalCollection") && loadType)
                {
                    autovoksalStages.Clear();
                }
                else
                {
                    throw new FormatException();
                }
                line = sr.ReadLine();
                EasyBus bus = null;
                string key = string.Empty;
                while (line != null && line.Contains("Autovoksal"))
                {
                    key = line.Split(separator)[1];
                    autovoksalStages.Add(key, new Autovoksal<EasyBus, RectangleForm>(pictureWidth, pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Bus") || line.Contains("BusGarm")))
                    {
                        if (line.Split(separator)[0] == "Bus")
                        {
                            bus = new Bus(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "BusGarm")
                        {
                            bus = new BusGarm(line.Split(separator)[1]);
                        }
                        var result = autovoksalStages[key] + bus;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }
        public void LoadOneLevel(string filename, bool loadType)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("OneAutovoksal") && !loadType)
                {
                }
                else
                {
                    throw new FormatException();
                }
                line = sr.ReadLine();
                EasyBus bus = null;
                string key = string.Empty;

                while (line != null && line.Contains("Autovoksal"))
                {
                    key = line.Split(separator)[1];
                    autovoksalStages.Add(key, new Autovoksal<EasyBus, RectangleForm>(pictureWidth, pictureHeight));
                    if (autovoksalStages.ContainsKey(key))
                    {
                        autovoksalStages[key].ClearStages();
                    }
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Bus") || line.Contains("BusGarm")))
                    {
                        if (line.Split(separator)[0] == "Bus")
                        {
                            bus = new Bus(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "BusGarm")
                        {
                            bus = new BusGarm(line.Split(separator)[1]);
                        }
                        line = sr.ReadLine();
                        var result = autovoksalStages[key] + bus;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                    }
                }
            }
        }
    }
}

