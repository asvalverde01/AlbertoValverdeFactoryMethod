using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Este código define un patrón de diseño de fábrica en el que se crean objetos de diferentes tipos (páginas de un documento). 
 * La clase "MainApp" es la clase principal que crea dos objetos de tipo "Documento", uno de tipo "Resume" y otro de tipo "Report".
 * Luego, se recorren las páginas de cada uno de estos documentos y se muestra en pantalla el nombre de cada página. La clase "Page"
 * es la clase abstracta para las diferentes páginas que se pueden crear y las clases concretas "SkillsPage", "EducationPage", etc. 
 * son diferentes tipos de páginas. La clase "Document" es la clase abstracta para los diferentes tipos de documentos que se pueden 
 * crear y las clases concretas "Resume" y "Report" son diferentes tipos de documentos que contienen diferentes conjuntos de páginas. 
 * La implementación específica de cómo se crean las páginas para cada tipo de documento se define en cada una de estas clases concretas.
 * */

namespace AlbertoValverdeFactoryMethod
{
    /// <summary>
    /// Clase principal de inicio de MainApp para el patrón de diseño de fábrica en el mundo real.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Punto de entrada a la aplicación de consola.
        /// </summary>
        static void Main()
        {
            // Nota: los constructores llaman al método de fábrica
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Mostrar páginas del documento
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            // Esperar al usuario
            Console.ReadKey();
        }
    }
    /// <summary>
    /// La clase 'Product' abstracta
    /// </summary>
    abstract class Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class SkillsPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class EducationPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class ExperiencePage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class IntroductionPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class ResultsPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class ConclusionPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class SummaryPage : Page
    {
    }
    /// <summary>
    /// Una clase 'ConcreteProduct'
    /// </summary>
    class BibliographyPage : Page
    {
    }
    /// <summary>
    /// La clase 'Creator' abstracta
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        // El constructor llama al método de fábrica abstracto
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }


    // Método de fábrica
    public abstract void CreatePages();
    }
    /// <summary>
    /// Una clase 'ConcreteCreator'
    /// </summary>
    class Resume : Document
    {
        // Implementación del método de fábrica
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
    /// <summary>
    /// Una clase 'ConcreteCreator'
    /// </summary>
    class Report : Document
    {
        // Implementación del método de fábrica
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}