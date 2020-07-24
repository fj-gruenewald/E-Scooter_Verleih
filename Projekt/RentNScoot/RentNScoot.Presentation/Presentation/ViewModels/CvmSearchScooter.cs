﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RentNScoot.Domain;

namespace RentNScoot.Presentation.ViewModels
{
    class CvmSearchScooter
    {
        #region fields
        private readonly CvmMain _vmMain;
        #endregion

        #region properties(Data)
        //
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        //
        private ICollection<Scooter> _searchResults = new List<Scooter>();

        //
        public ICollection<Scooter> SearchResults
        {
            get
            {
                return _searchResults;
            }
            set
            {
                _searchResults = value ?? new List<Scooter>();
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SearchResults"));
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ButtonText"));
            }
        }

        //
        private Scooter _selectedScooter = new Scooter();
        private ICollection<Scooter> _selectedCarsList = new List<Scooter>();

        //
        public Scooter SelectedScooter
        {
            get
            {
                return _selectedScooter;
            }
            set
            {
                _selectedScooter = value;
                _selectedCarsList.Add(_selectedScooter);
            }
        }
        #endregion

        #region properties(Command)

        #endregion

        #region ctor
        private static volatile CvmSearchScooter? instance = null;

        private static readonly object padlock = new object();

        private CvmSearchScooter(CvmMain vmMain)
        {
            _vmMain = vmMain;
        }

        internal static CvmSearchScooter CreateSingleton(CvmMain vmMain)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new CvmSearchScooter(vmMain);
                }
                return instance;
            }
        }
        #endregion

        #region events

        #endregion
    }
}
