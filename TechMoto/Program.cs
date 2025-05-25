using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TechMoto
{
    internal static class Program
    {
        public static Classes.Usuario UsuarioTroca = null;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        reiniciar:
            Classes.Usuario usuarioLogado;

            if (UsuarioTroca != null)
            {
                usuarioLogado = UsuarioTroca;
                UsuarioTroca = null;
            }
            else
            {
                using (frmLogin loginForm = new frmLogin())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK)
                        return; 

                    usuarioLogado = loginForm.UsuarioLogado;
                }
            }

            using (frmMain mainForm = new frmMain(usuarioLogado))
            {
                Application.Run(mainForm);
            }

            if (UsuarioTroca != null)
            {
                goto reiniciar;
            }
        }
    }
}
