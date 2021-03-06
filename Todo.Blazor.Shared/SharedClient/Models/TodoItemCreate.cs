﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Todo.Blazor.Shared.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class TodoItemCreate
    {
        /// <summary>
        /// Initializes a new instance of the TodoItemCreate class.
        /// </summary>
        public TodoItemCreate() { }

        /// <summary>
        /// Initializes a new instance of the TodoItemCreate class.
        /// </summary>
        public TodoItemCreate(string title)
        {
            Title = title;
        }

        /// <summary>
        /// The title must be unique within the list it belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (this.Title != null)
            {
                if (this.Title.Length > 125)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Title", 125);
                }
            }
        }
    }
}
