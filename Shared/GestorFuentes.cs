using System.Drawing.Text;
using System.IO;
using System.Reflection;

namespace CentroMedico.Shared
{
    public static class GestorFuentes
    {
        public static readonly PrivateFontCollection TelegrafFontCollection;
        public static readonly FontFamily TelegrafFontFamily;

        static GestorFuentes()
        {
            TelegrafFontCollection = new PrivateFontCollection();
            string rutaFuente = Path.Combine(Application.StartupPath, "Recursos", "Fuentes", "TelegrafUltraBold.ttf");
            TelegrafFontCollection.AddFontFile(rutaFuente);
            TelegrafFontFamily = TelegrafFontCollection.Families[0];
        }
    }
}
