using C5;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace CentroMedico.Utils
{
    internal class GraphUtils
    {
        TreeDictionary<int, string> arbol = new TreeDictionary<int, string>();
        Graph graph = new Graph("Centro Medico");

        public void AgregarArbol(int key, string value)
        {
            if (!arbol.Contains(key))
            {
                arbol.Add(key, value);
            }
        }

        public void AgregarNodoGrafo()
        {
            foreach (var nodo in arbol)
            {
                graph.AddNode(nodo.Key.ToString()).LabelText = nodo.Value;
            }
        }

        public Graph Unir(Graph graph, int padre, int hijo)
        {
            if (graph.FindNode(padre.ToString()) != null && graph.FindNode(hijo.ToString()) != null)
            {
                graph.AddEdge(padre.ToString(), hijo.ToString());
            }
            return graph;
        }

        public void RelacionarGrafo(string padre, string hijo)
        {
            graph = Unir(graph, Convert.ToInt32(padre), Convert.ToInt32(hijo));
        }

        public void MostrarGrafo()
        {
            Form ventanaArbol = new Form
            {
                Text = "Visualización del Árbol",
                Width = 800,
                Height = 600
            };

            var vista = new GViewer
            {
                Graph = graph,
                Dock = DockStyle.Fill
            };
            ventanaArbol.Controls.Add(vista);
            ventanaArbol.Show();
        }

        public static GraphUtils Instancia { get; } = new GraphUtils();
    }
}
