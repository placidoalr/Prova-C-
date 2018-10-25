using ProvaParteII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaParteII.Controllers
{
    public class EstudanteController : Controller
    {
		IList<Estudante> estudantes;

		public EstudanteController()
		{
			estudantes = getFromSession();

			if (estudantes == null)
			{
				estudantes = new List<Estudante>();
			}

			

		}
		public IList<Estudante> getFromSession()
		{
			IList<Estudante> listaTemporaria = (List<Estudante>)System.Web.HttpContext.Current.Session["listaTemporaria"];

			return listaTemporaria;


		}

		public void setToSession(IList<Estudante> estudantes)
		{
			System.Web.HttpContext.Current.Session["listaTemporaria"] = estudantes;

		}
		// GET: Estudante
		public ActionResult Index()
		{


			IEnumerable<Estudante> estu = estudantes.OrderBy(e => e.id);
			return View((IEnumerable<Estudante>)estu);

		}

		// GET: Estudante/Create
		public ActionResult Create()
		{
			return View();
		}


		[HttpPost]
		public ActionResult Create(Estudante estudante)
		{
				if (ModelState.IsValid) { 
				if (estudantes.Count == 0)
				{
					estudante.id = 1;
				
				}
				else
				{
					estudante.id = estudantes[estudantes.Count - 1].id + 1;
				
				}
				estudantes.Add(estudante);
				setToSession(estudantes);

				return RedirectToAction("Index");
			}
			else
			{
				return View(estudante);
			}
		}



		// GET: Estudante/Edit/5
		public ActionResult Edit(int id)
		{
			Estudante e = estudantes.First(es => es.id.Equals(id));
			return View("Edit", e);
		}

		// POST: Estudante/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here
				Estudante e = estudantes.First(es => es.id.Equals(id));
				estudantes.Remove(e);
				e.Nome = collection["Nome"];
				e.Idade = int.Parse(collection["Idade"]);
				e.Matricula = collection["Matricula"];

				estudantes.Add(e);
				setToSession(estudantes);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Estudante/Delete/5
		public ActionResult Delete(int id)
		{
			Estudante e = estudantes.First(es => es.id.Equals(id));
			return View("Delete", e);
		}

		// POST: Estudante/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here
				Estudante e = estudantes.First(es => es.id.Equals(id));
				estudantes.Remove(e);

				setToSession(estudantes);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}