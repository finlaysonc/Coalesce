
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Intellitect.ComponentModel.Interfaces;
using Intellitect.ComponentModel.Models;
using Intellitect.ComponentModel.Mapping;
using System.Linq;
using Newtonsoft.Json;
// Model Namespaces
    using Coalesce.Domain;
    using Coalesce.Domain.External;
using static Coalesce.Domain.Product;

namespace Coalesce.Web.TestArea.Models
{
    public partial class ProductDtoGen : GeneratedDto<Product, ProductDtoGen>
        , IClassDto<Product, ProductDtoGen>
        {
        public ProductDtoGen() { }

             public Int32? ProductId { get; set; }
             public String Name { get; set; }

        // Create a new version of this object or use it from the lookup.
        public static ProductDtoGen Create(Product obj, ClaimsPrincipal user = null, string includes = null,
                                   Dictionary<string, object> objects = null) {
            if (objects == null) objects = new Dictionary<string, object>();

            if (user == null) throw new InvalidOperationException("Updating an entity requires the User property to be populated.");

            includes = includes ?? "";

            // Applicable includes for Product
            

            // Applicable excludes for Product
            

            // Applicable roles for Product
            if (user != null)
			{
			}



            // See if the object is already created.
            if (objects.ContainsKey($"Product{obj.ProductId}" )) 
                return (ProductDtoGen)objects[$"Product{obj.ProductId}"];

            var newObject = new ProductDtoGen();
            // Fill the properties of the object.
            newObject.Name = obj.Name;
            return newObject;
        }

        // Instance constructor because there is no way to implement a static interface in C#.
        public ProductDtoGen CreateInstance(Product obj, ClaimsPrincipal user = null, string includes = null,
                                Dictionary<string, object> objects = null) {
            return Create(obj, user, includes, objects);
        }

        // Updates an object from the database to the state handed in by the DTO.
        public void Update(Product entity, ClaimsPrincipal user = null, string includes = null)
        {
        if (user == null) throw new InvalidOperationException("Updating an entity requires the User property to be populated.");

        includes = includes ?? "";

        if (OnUpdate(entity, user, includes)) return;

        // Applicable includes for Product
        

        // Applicable excludes for Product
        

        // Applicable roles for Product
        if (user != null)
			{
			}

			entity.Name = Name;
        }

        public void SecurityTrim(ClaimsPrincipal user = null, string includes = null)
        {
        if (OnSecurityTrim(user, includes)) return;

        // Applicable includes for Product
        

        // Applicable excludes for Product
        

        // Applicable roles for Product
        if (user != null)
			{
			}

        }
        }
        }