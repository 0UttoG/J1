using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J1
{
    public partial class Jugar : Form
    {
        private List<Pregunta> preguntas;
        private int indicePreguntaActual;
        private string nombreJugador;
        private string categoria;
        private int intentosRestantes;
        private int preguntasCorrectas = 0;
        private readonly int intentosIniciales;
        private int tiempoRestante;
        private const int TIEMPO_POR_PREGUNTA = 100;

        public Jugar(string nombre, string categoriaSeleccionada, int intentos)
        {
            InitializeComponent();

            nombreJugador = nombre;
            categoria = categoriaSeleccionada;
            intentosRestantes = intentos;
            intentosIniciales = intentos;

            lblJugador.Text = $"Jugador: {nombreJugador}";
            lblCategoria.Text = $"Categoría: {categoria}";
            lblIntentos.Text = $"Intentos: {intentosRestantes}";

            CargarPreguntas();
            MostrarPregunta();

            this.Resize += Jugar_Resize;
            Jugar_Resize(null, null);
        }

        private void CargarPreguntas()
        {
            preguntas = new List<Pregunta>();
            int cantidadPreguntasPorPartida = 12;

            if (categoria == "Historia")
            {
                List<Pregunta> preguntasHistoria = new List<Pregunta>
        {
            new Pregunta("¿En qué año cayó el Imperio Romano de Occidente?", new string[] { "395", "476", "1492", "1789" }, 1),
            new Pregunta("¿Quién fue el primer presidente de EE.UU.?", new string[] { "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams" }, 1),
            new Pregunta("¿Qué civilización construyó Machu Picchu?", new string[] { "Aztecas", "Mayas", "Incas", "Olmecas" }, 2),
            new Pregunta("¿En qué año Colón llegó a América?", new string[] { "1492", "1521", "1607", "1776" }, 0),
new Pregunta("¿Quién fue el primer emperador romano?", new string[] { "Julio César", "Augusto", "Nerón", "Constantino" }, 1),
new Pregunta("¿Qué civilización construyó las pirámides de Giza?", new string[] { "Griegos", "Romanos", "Egipcios", "Persas" }, 2),
new Pregunta("¿En qué siglo ocurrió la Revolución Francesa?", new string[] { "XV", "XVI", "XVII", "XVIII" }, 3),
new Pregunta("¿Quién escribió 'El Príncipe'?", new string[] { "Maquiavelo", "Dante", "Shakespeare", "Cervantes" }, 0),
new Pregunta("¿Qué batalla marcó el fin de Napoleón?", new string[] { "Waterloo", "Austerlitz", "Trafalgar", "Borodino" }, 0),
new Pregunta("¿Dónde surgió la cultura micénica?", new string[] { "Italia", "Grecia", "Egipto", "Mesopotamia" }, 1),
new Pregunta("¿Quién fue el líder de la Revolución Rusa de 1917?", new string[] { "Stalin", "Lenin", "Trotsky", "Kerensky" }, 1),
new Pregunta("¿Qué dinastía gobernó China durante la construcción de la Gran Muralla?", new string[] { "Han", "Qin", "Ming", "Tang" }, 1),
new Pregunta("¿En qué año cayó el Muro de Berlín?", new string[] { "1985", "1989", "1991", "1975" }, 1),
new Pregunta("¿Qué imperio dominó México antes de la llegada de los españoles?", new string[] { "Inca", "Maya", "Azteca", "Tolteca" }, 2),
new Pregunta("¿Quién fue el faraón que gobernó durante el Éxodo bíblico?", new string[] { "Keops", "Tutankamón", "Ramsés II", "Akenatón" }, 2),
new Pregunta("¿Qué evento inició la Primera Guerra Mundial?", new string[] { "Invasión de Polonia", "Asesinato del archiduque Francisco Fernando", "Bombardeo de Pearl Harbor", "Revolución Rusa" }, 1),
new Pregunta("¿Quién descubrió la tumba de Tutankamón?", new string[] { "Howard Carter", "Flinders Petrie", "Jean-François Champollion", "Heinrich Schliemann" }, 0),
new Pregunta("¿Qué ciudad fue capital del Imperio Bizantino?", new string[] { "Roma", "Atenas", "Constantinopla", "Antioquía" }, 2),
new Pregunta("¿En qué año se firmó la Declaración de Independencia de EE.UU.?", new string[] { "1776", "1789", "1801", "1750" }, 0),
new Pregunta("¿Quién fue el primer rey de España unificada?", new string[] { "Carlos I", "Felipe II", "Fernando el Católico", "Isabel la Católica" }, 2),


            // ← Aquí irían tus otras 27 preguntas
        };

                preguntas = preguntasHistoria.OrderBy(p => Guid.NewGuid()).Take(cantidadPreguntasPorPartida).ToList();
            }
            else if (categoria == "Matemáticas")
            {
                List<Pregunta> preguntasMatematicas = new List<Pregunta>
        {
            new Pregunta("¿Cuánto es 7 × 8?", new string[] { "54", "56", "64", "49" }, 1),
            new Pregunta("Si 2³ es igual a...?", new string[] { "4", "8", "6", "9" }, 1),
            new Pregunta("¿Cuál es el valor aproximado de π?", new string[] { "2.14", "3.5", "3.1416", "4.2" }, 2),
            // ← Tus otras 27 preguntas
        };

                preguntas = preguntasMatematicas.OrderBy(p => Guid.NewGuid()).Take(cantidadPreguntasPorPartida).ToList();
            }
            else if (categoria == "Ciencia")
            {
                List<Pregunta> preguntasCiencia = new List<Pregunta>
        {
            new Pregunta("¿Qué planeta es conocido como el 'planeta rojo'?", new string[] { "Venus", "Marte", "Júpiter", "Saturno" }, 1),
            new Pregunta("¿Quién formuló la teoría de la relatividad?", new string[] { "Isaac Newton", "Albert Einstein", "Nikola Tesla", "Galileo Galilei" }, 1),
            new Pregunta("¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?", new string[] { "Fermentación", "Fotosíntesis", "Digestión", "Oxidación" }, 1),
            // ← Las otras 27
        };

                preguntas = preguntasCiencia.OrderBy(p => Guid.NewGuid()).Take(cantidadPreguntasPorPartida).ToList();
            }
            else if (categoria == "Deportes")
            {
                List<Pregunta> preguntasDeportes = new List<Pregunta>
        {
            new Pregunta("¿Cuántos jugadores hay en un equipo de fútbol en el campo?", new string[] { "9", "11", "12", "15" }, 1),
            new Pregunta("¿En qué deporte se usa un bate y una pelota pequeña?", new string[] { "Fútbol", "Béisbol", "Baloncesto", "Hockey" }, 1),
            new Pregunta("¿Cuántos puntos vale un triple en baloncesto?", new string[] { "1", "2", "3", "4" }, 2),
            new Pregunta("¿En qué deporte se utiliza un balón de forma ovalada?", new string[] { "Fútbol", "Béisbol", "Fútbol americano", "Baloncesto" }, 2),
            // ← Tus otras 26
        };

                preguntas = preguntasDeportes.OrderBy(p => Guid.NewGuid()).Take(cantidadPreguntasPorPartida).ToList();
            }
            else if (categoria == "Aleatoria")
            {
                List<Pregunta> todas = new List<Pregunta>();

                // Añadir todas las preguntas de todas las categorías acá
                // Historia
                todas.Add(new Pregunta("¿En qué año cayó el Imperio Romano de Occidente?", new string[] { "395", "476", "1492", "1789" }, 1));
                todas.Add(new Pregunta("¿Quién fue el primer presidente de EE.UU.?", new string[] { "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams" }, 1));
                todas.Add(new Pregunta("¿Qué civilización construyó Machu Picchu?", new string[] { "Aztecas", "Mayas", "Incas", "Olmecas" }, 2));

                // Matemáticas
                todas.Add(new Pregunta("¿Cuánto es 7 × 8?", new string[] { "54", "56", "64", "49" }, 1));
                todas.Add(new Pregunta("Si 2³ es igual a...?", new string[] { "4", "8", "6", "9" }, 1));
                todas.Add(new Pregunta("¿Cuál es el valor aproximado de π?", new string[] { "2.14", "3.5", "3.1416", "4.2" }, 2));

                // Ciencia
                todas.Add(new Pregunta("¿Qué planeta es conocido como el 'planeta rojo'?", new string[] { "Venus", "Marte", "Júpiter", "Saturno" }, 1));
                todas.Add(new Pregunta("¿Quién formuló la teoría de la relatividad?", new string[] { "Isaac Newton", "Albert Einstein", "Nikola Tesla", "Galileo Galilei" }, 1));
                todas.Add(new Pregunta("¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?", new string[] { "Fermentación", "Fotosíntesis", "Digestión", "Oxidación" }, 1));

                // Deportes
                todas.Add(new Pregunta("¿Cuántos jugadores hay en un equipo de fútbol en el campo?", new string[] { "9", "11", "12", "15" }, 1));
                todas.Add(new Pregunta("¿En qué deporte se usa un bate y una pelota pequeña?", new string[] { "Fútbol", "Béisbol", "Baloncesto", "Hockey" }, 1));
                todas.Add(new Pregunta("¿Cuántos puntos vale un triple en baloncesto?", new string[] { "1", "2", "3", "4" }, 2));

                preguntas = todas.OrderBy(p => Guid.NewGuid()).Take(cantidadPreguntasPorPartida).ToList();
            }

            indicePreguntaActual = 0;
        }


        private void MostrarPregunta()
        {
            if (indicePreguntaActual < preguntas.Count)
            {
                var preguntaActual = preguntas[indicePreguntaActual];
                lblPregunta.Text = preguntaActual.Enunciado;
                btnOpcion1.Text = preguntaActual.Opciones[0];
                btnOpcion2.Text = preguntaActual.Opciones[1];
                btnOpcion3.Text = preguntaActual.Opciones[2];
                btnOpcion4.Text = preguntaActual.Opciones[3];

                tiempoRestante = TIEMPO_POR_PREGUNTA;
                progressBarTiempo.Value = TIEMPO_POR_PREGUNTA;
                timerPregunta.Start();
            }
            else
            {
                timerPregunta.Stop();
                double porcentajeCorrectas = (double)preguntasCorrectas / preguntas.Count * 100;

                if (porcentajeCorrectas <= 50)
                {
                    Perder formPerder = new Perder(nombreJugador, preguntasCorrectas, preguntas.Count);
                    this.Hide();
                    formPerder.ShowDialog();
                    this.Close();
                }
                else
                {
                    Ganar formularioGanar = new Ganar(nombreJugador, preguntasCorrectas, preguntas.Count);
                    this.Hide();
                    formularioGanar.ShowDialog();
                    this.Close();
                }
            }
        }

        private async void AnimarErrorEnPanel()
        {
            var original = PanelPreguntas.Location;
            var rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int offsetX = rnd.Next(-5, 6);
                int offsetY = rnd.Next(-5, 6);
                PanelPreguntas.Location = new Point(original.X + offsetX, original.Y + offsetY);
                await Task.Delay(30);
            }

            PanelPreguntas.Location = original;
        }

        private async void AnimarAcierto()
        {
            // Mostrar mensaje de correcto
            var lblCorrecto = new Label()
            {
                Text = "¡Correcto!",
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Green,
                AutoSize = true,
                Location = new Point(
                    PanelPreguntas.Width / 2 - 50,
                    PanelPreguntas.Height / 2 - 20)
            };

            PanelPreguntas.Controls.Add(lblCorrecto);
            lblCorrecto.BringToFront();

            // Animación de escala y fade out
            for (int i = 1; i <= 10; i++)
            {
                lblCorrecto.Font = new Font("Arial", 20 + i * 2, FontStyle.Bold);
                lblCorrecto.Location = new Point(
                    PanelPreguntas.Width / 2 - lblCorrecto.Width / 2,
                    PanelPreguntas.Height / 2 - lblCorrecto.Height / 2);
                await Task.Delay(50);
            }

            // Remover el label después de la animación
            await Task.Delay(300);
            PanelPreguntas.Controls.Remove(lblCorrecto);
        }

        private void VerificarRespuesta(int indiceOpcion)
        {
            timerPregunta.Stop();

            if (indiceOpcion == preguntas[indicePreguntaActual].RespuestaCorrecta)
            {
                preguntasCorrectas++;
                AnimarAcierto();
            }
            else
            {
                intentosRestantes--;
                lblIntentos.Text = $"Intentos: {intentosRestantes}";
                AnimarErrorEnPanel();

                if (intentosRestantes <= 0)
                {
                    Perder formPerder = new Perder(nombreJugador, preguntasCorrectas, preguntas.Count);
                    this.Hide();

                    if (formPerder.ShowDialog() == DialogResult.Retry)
                    {
                        intentosRestantes = intentosIniciales;
                        indicePreguntaActual = 0;
                        preguntasCorrectas = 0;
                        lblIntentos.Text = $"Intentos: {intentosRestantes}";
                        MostrarPregunta();
                        this.Show();
                        return;
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                }
            }

            indicePreguntaActual++;
            MostrarPregunta();
        }

        private void btnOpcion1_Click(object sender, EventArgs e) => VerificarRespuesta(0);
        private void btnOpcion2_Click(object sender, EventArgs e) => VerificarRespuesta(1);
        private void btnOpcion3_Click(object sender, EventArgs e) => VerificarRespuesta(2);
        private void btnOpcion4_Click(object sender, EventArgs e) => VerificarRespuesta(3);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Jugar_Resize(object sender, EventArgs e)
        {
            CentrarPanelesJuntos(PanelDJugador, PanelPreguntas, espacio: 30);
        }

        private void CentrarPanelesJuntos(Control panel1, Control panel2, int espacio = 20)
        {
            int totalAncho = panel1.Width + espacio + panel2.Width;
            int startX = (this.ClientSize.Width - totalAncho) / 2;
            int centerY = (this.ClientSize.Height - Math.Max(panel1.Height, panel2.Height)) / 2;

            panel1.Location = new Point(startX, centerY);
            panel2.Location = new Point(startX + panel1.Width + espacio, centerY);
        }

        private void timerPregunta_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            progressBarTiempo.Value = Math.Max(0, tiempoRestante);

            if (tiempoRestante <= 0)
            {
                timerPregunta.Stop();
                intentosRestantes--;
                lblIntentos.Text = $"Intentos: {intentosRestantes}";

                if (intentosRestantes <= 0)
                {
                    Perder formPerder = new Perder(nombreJugador, preguntasCorrectas, preguntas.Count);
                    this.Hide();

                    if (formPerder.ShowDialog() == DialogResult.Retry)
                    {
                        intentosRestantes = intentosIniciales;
                        indicePreguntaActual = 0;
                        preguntasCorrectas = 0;
                        lblIntentos.Text = $"Intentos: {intentosRestantes}";
                        MostrarPregunta();
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    indicePreguntaActual++;
                    MostrarPregunta();
                }
            }
        }

        private void progressBarTiempo_Click(object sender, EventArgs e) { }
        private void lblErrores_Click(object sender, EventArgs e) { }
        private void PanelPreguntas_Paint(object sender, PaintEventArgs e) { }
        private void PanelDJugador_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void Guna2Panel_Paint(object sender, PaintEventArgs e) { }
    }

    public class Pregunta
    {
        public string Enunciado { get; }
        public string[] Opciones { get; }
        public int RespuestaCorrecta { get; }

        public Pregunta(string enunciado, string[] opciones, int respuestaCorrecta)
        {
            Enunciado = enunciado;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }
    }
}









