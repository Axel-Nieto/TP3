﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class SalaUrgencia:Sala
    {
        public SalaUrgencia()
        {
        }

        /// <summary>
        /// Ejecuta el metodo atender de un objeto que hace uso de la interfaz IAtender
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        /// <returns>Devuelve el primer objeto de la lista</returns>
        public override Object Atender(Object[] pLista)
        {
            ContextoAtender contexto = new ContextoAtender(new AtenderTriaje());
            return contexto.Atender(pLista);
        }

        /// <summary>
        /// Ejecuta el metodo MostrarPacientes de un objeto que hace uso de la interfaz IMostrarPacientes
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        public override void MostrarPacientes(Object[] pLista)
        {
            ContextoMostrarPacientes contexto = new ContextoMostrarPacientes(new MostrarPacientesUrgencias());
            contexto.MostrarPacientes(pLista);
        }

        /// <summary>
        /// Ejecuta el metodo OtorgarTurno de un objeto que hace uso de la interfaz IOtorgarTurno
        /// </summary>
        /// <param name="pRepositorioPacientes">Repositorio que almacena los pacientes de las salas</param>
        public override void OtorgarTurno(RepositorioPacientes pRepositorioPacientes)
        {
            ContextoOtorgarTurno contexto = new ContextoOtorgarTurno(new OtorgarTurnoUrgencia());
            contexto.OtorgarTurno(pRepositorioPacientes);
        }
    }
}
