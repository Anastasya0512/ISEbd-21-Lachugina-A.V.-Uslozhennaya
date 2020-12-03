using System;
using System.Collections.Generic;
using System.Linq;
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
                    return autovoksalStages[key][ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

