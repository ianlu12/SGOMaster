using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGOMaster
{
    class WeaponClass
    {
        private Dictionary<string, string> weaponDic;

        public WeaponClass()
        {
            weaponDic = new Dictionary<string, string>();
            weaponDic.Add("單手劍", "sword");
            weaponDic.Add("細劍", "rapier");
            weaponDic.Add("短刀", "dagger");   
            weaponDic.Add("單手錘", "hammer"); 
            weaponDic.Add("盾牌", "shield");   
            weaponDic.Add("雙手劍", "thsword");
            weaponDic.Add("太刀", "katana");   
            weaponDic.Add("雙手斧", "axe");    
            weaponDic.Add("長槍", "spear");    
            weaponDic.Add("大衣", "coat");     
            weaponDic.Add("盔甲", "armor");    
        }

        //取得中文名稱
        /*public string GetWeaponCN(string enName)
        {
            return weaponDic.ge;
        }*/

        //取得文名稱
        public string GetWeaponEN(string cnName)
        {
            return weaponDic[cnName];
        }
    }

}
