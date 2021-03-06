﻿using System.Collections.Generic;
using System.Linq;
using Connecto.BusinessObjects;
using Connecto.DataObjects.EntityFramework.ModelMapper;

namespace Connecto.DataObjects.EntityFramework.Implementation
{
    /// <summary>
    /// Entity Framework implementation of the IContactDao interface.
    /// </summary>
    public class EntityContactDao : IContactDao
    {
        // get all Contacts
        public List<Contact> GetContacts()
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var contacts = context.Contacts.ToList();
                return contacts.Select(Mapper.Map).ToList();
            }
        }


        // get Contact by id
        public Contact GetContact(int contactId)
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var entity = context.Contacts.FirstOrDefault(e => e.ContactId == contactId);
                return entity == null ? null : Mapper.Map(entity);
            }
        }

        public int AddContact(Contact contact)
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var entity = Mapper.Map(contact);
                context.Contacts.Add(entity);
                context.SaveChanges();
                return entity.ContactId;
            }
        }

        public int DeleteContact(int id = 0)
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var entity = context.Contacts.FirstOrDefault(s => s.ContactId == id);
                context.Contacts.Remove(entity);
                return context.SaveChanges();
            }
        }

    }
}
