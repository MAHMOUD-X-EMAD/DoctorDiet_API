using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sakiny.Repository.Interfaces;
using Saking.Reposetory.UnitOfWork;
using Sakiny.DTO;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class ReportService
    {
        IGenericRepository<Report> _repository;
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public ReportService(IGenericRepository<Report> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository=repository;
            _unitOfWork=unitOfWork;
            _mapper=mapper;
        }

        public IEnumerable<ReportDto> GetAllReports()
        {
            IQueryable<Report> repots= _repository.GetAll();

            return repots.ProjectTo<ReportDto>(_mapper.ConfigurationProvider); //return IQuerable
        }

        public ReportDto GetByReportID(int id)
        {
            Report report = _repository.GetByID(id);

            return _mapper.Map<ReportDto>(report);
        }

        public ReportDto GetReportByUserID(string userID)
        {
           Report report=_repository.Get(user => user.UserId == userID).FirstOrDefault();

            return _mapper.Map<ReportDto>(report);
        }

        public Report AddReport(ReportCtreateDto reportDto)
        {
            Report report=_mapper.Map<Report>(reportDto);
            _repository.Add(report);
            _unitOfWork.SaveChanges();

            return report;
        }

        public string UpdateReport(Report report,params string[] updatedProp)
        {
            _repository.Update(report,updatedProp);
            _unitOfWork.SaveChanges();

            return report.Status.ToString();
        }
    }
}
