using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClikerCalculator
{
    class Effects
    {
        public void applyEffect(int idEffect, Buildings bui) 
        {
            switch (idEffect)
            {
                case 0: //Grandmas are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 1: //Frams are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 2: //Mines are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 3: //Factories are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 4: //Banks are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;

                    break;

                case 5: //Temples are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 6: //Wizard are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 7: //Shipments are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 8: //Alchemy labs are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 9: //Portals are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 10: //Time machines are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 11: //Antimatter condensers are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                case 12: //Prisms are twice as efficient.
                    bui.BaseCps = bui.BaseCps * 2;
                    break;

                default:
                    break;
            }
        }

        public void desapplyEffect(int idEffect, Buildings bui) 
        {
            switch (idEffect)
            {
                case 0: //Grandmas are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 1: //Frams are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 2: //Mines are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 3: //Factories are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 4: //Banks are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;

                    break;

                case 5: //Temples are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 6: //Wizard are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 7: //Shipments are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 8: //Alchemy labs are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 9: //Portals are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 10: //Time machines are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 11: //Antimatter condensers are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                case 12: //Prisms are twice as efficient.
                    bui.BaseCps = bui.BaseCps / 2;
                    break;

                default:
                    break;
            }
        }
    }
}
