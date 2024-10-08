using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KnowledgeBase.Patterns.Models;
using KnowledgeBase.Patterns.Core.DataTypes.DataCollections;
using KnowledgeBase.Patterns.Core.DependencyInjection;
using KnowledgeBase.Patterns.Core.Interfaces;
using KnowledgeBase.Patterns.Core.Middlewares;

namespace KnowledgeBase.Patterns.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConceptController : ControllerBase
    {
        private readonly ILogger<ConceptController> _logger;

        public ConceptController(ILogger<ConceptController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Concept Get()
        {
            return new Concept
            {
                Name = "Name", 
                Family = "Family",
                ExecSummary = "Summary"
            };
        }

        [HttpGet("{name}")]
        public Concept Get(string name)
        {
            return new Concept
            {
                Family = name,
                IsExecuted = true,
                Result = "result for " + name,
                ExecSummary = "Summary " + name
            };
        }

        [HttpGet("solid/{name}")]
        public Concept GetSolid(string name)
        {
            return new Concept
            {
                Name = name, 
                Family = "SOLID",
                IsExecuted = true,
                Result = "result for " + name,
                ExecSummary = "Executed"
            };
        }

        [HttpGet("grasp/{name}")]
        public Concept GetGrasp(string name)
        {
            return new Concept
            {
                Name = name, 
                Family = "GRASP",
                IsExecuted = true,
                Result = "result for " + name,
                ExecSummary = "Executed"
            };
        }

        [HttpGet("design/{name}")]
        public Concept GetDesign(string name)
        {
            return new Concept
            {
                Name = name, 
                Family = "Design patterns",
                IsExecuted = true,
                Result = "result for " + name,
                ExecSummary = "Executed"
            };
        }

        [HttpGet("middlewares/{name}")]
        public Concept GetMiddleware(string name)
        {
            string result = string.Empty; 
            try
            {
                IConceptCore implementation = 
                    name == "MiddlewarePipeFunc" ? (IConceptCore)(new MiddlewarePipeFunc()) 
                        : (IConceptCore)(new MiddlewarePipeDI()); 
                result = implementation.Execute();
            }
            catch (System.Exception ex)
            {
                result = "Unable to execute: " + ex.Message; 
            }
            return new Concept
            {
                Name = name, 
                Family = "Middlewares",
                IsExecuted = true,
                Result = "result for " + name + ": " + result,
                ExecSummary = "Executed"
            };
        }

        [HttpGet("di/{name}")]
        public Concept GetDependencyInjection(string name)
        {
            string result = string.Empty; 
            try
            {
                IConceptCore implementation = 
                    name == "DIBuilderLifetime" ? (IConceptCore)(new DIBuilderLifetime()) 
                        : (IConceptCore)(new DIBuilder()); 
                result = implementation.Execute();
            }
            catch (System.Exception ex)
            {
                result = "Unable to execute: " + ex.Message; 
            }
            return new Concept
            {
                Name = name, 
                Family = "Dependency injection",
                IsExecuted = true,
                Result = "result for " + name + ": " + result,
                ExecSummary = "Executed"
            };
        }

        [HttpGet("datatypes/datacollections/{name}")]
        public Concept GetDataCollections(string name)
        {
            string result = string.Empty; 
            try
            {
                IConceptCore implementation = new TestingArrays();
                result = implementation.Execute();
            }
            catch (System.Exception ex)
            {
                result = "Unable to execute: " + ex.Message; 
            }
            return new Concept
            {
                Name = name, 
                Family = "DataTypes/DataCollections",
                IsExecuted = true,
                Result = "result for " + name + ": " + result,
                ExecSummary = "Executed"
            };
        }

        [HttpPost]
        public Concept Post(Concept concept)
        {
            return concept;
        }
    }
}
