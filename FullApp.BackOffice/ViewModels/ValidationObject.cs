﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.BackOffice.ViewModels
{
    public class ValidationObject : NotificationObject, INotifyDataErrorInfo
    {
        private Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

        public bool HasErrors
        {
            get
            {
                return errors.Any();
            }
        }       

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {            
            if (errors.ContainsKey(propertyName))
            {
                return errors[propertyName];
            }

            return new List<string>();           
        }

        protected override void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            base.SetProperty<T>(ref member, val, propertyName);
            ValidateProperty(val, propertyName);        
        }

        public void ValidateProperty<T>(T val, string propertyName)
        {
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }


        protected void AddError(string errorMessage, [CallerMemberName] string propertyName =null)
        {              
            errors.Add(propertyName,  new List<string> { errorMessage, errorMessage } );
        }
    }
}
