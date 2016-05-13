﻿using System;
using AntMe.Items.Basics;

namespace AntMe.Factions.Ants
{
    /// <summary>
    /// Interop Klasse für alle Ameisen
    /// </summary>
    public sealed class AntUnitInterop : UnitInterop<AntFaction, AntItem>
    {
        public AntUnitInterop(AntFaction faction, AntItem item) : base(faction, item)
        {
        }

        /// <summary>
        ///     Wird von der Faction beim Update dieser Einheit aufgerufen.
        /// </summary>
        protected override void Update(int round)
        {
            // Tick ausführen
            if (Tick != null)
                Tick();
        }

        #region Eigenschaften

        /// <summary>
        ///     Liefert die Faction-weite Instanz eines Zufallsgenerators.
        /// </summary>
        public Random Random { get { return Faction.Context.Random; } }

        /// <summary>
        /// Gibt die Ausrichtung der Ameise zurück.
        /// </summary>
        public Angle Orientation { get { return Item.Orientation; }}

        #endregion

        #region Events

        /// <summary>
        ///     Event wird in jeder Runde einmal aufgerufen.
        /// </summary>
        public event InteropProperty.InteropEvent Tick;

        #endregion
    }
}