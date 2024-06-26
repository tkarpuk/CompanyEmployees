﻿using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CompanyService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _logger = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges)
        {
            try
            {
                var companies = _repository.Company.GetAllCompanies(trackChanges);
                //var companiesDto = companies.Select(c =>
                //    new CompanyDto(c.Id, c.Name ?? "", c.Address + " " + c.Country))
                //    .ToList();
                var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);

                return companiesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllCompanies)} service method {ex}.");
                throw;
            }
        }
    }
}
