using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borderless_explorer
{
    // 以下定義JS呼叫的function, 技能function名稱開頭要是小寫英文, 否則JS會抓不到
    class BoundObject
    {
        public void mouse_move(int x, int y)
        {
            Program.main_form.Controll_down_btn_visible(x, y);
        }
    }
}
