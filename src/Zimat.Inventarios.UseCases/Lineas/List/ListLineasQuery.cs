using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Unidades;

namespace Zimat.Inventarios.UseCases.Lineas.List;
public record ListLineasQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<LineaDTO>>>;

