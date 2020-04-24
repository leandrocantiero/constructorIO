using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
        }



        /*insert into estado (uf, nome) values('SP', 'São Paulo');
insert into estado (uf, nome) values('RJ', 'Rio de Janeiro');


insert into cidade (uf_estado, nome) values('SP', 'Presidente Prudente');
insert into cidade (uf_estado, nome) values('SP', 'São Paulo');

insert into cidade (uf_estado, nome) values('RJ', 'Rio de Janeiro');*/
    }
}
