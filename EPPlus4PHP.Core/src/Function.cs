using System;
using System.Collections.Generic;
using Pchp.Core;
using Pchp.Library;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using OfficeOpenXml.FormulaParsing.ExpressionGraph;
using ExcelDataType = OfficeOpenXml.FormulaParsing.ExpressionGraph.DataType;
using OfficeOpenXml.FormulaParsing.Exceptions;

namespace nulastudio.Document.EPPlus4PHP
{
    public class Function : ExcelFunction
    {
        private Context _ctx;
        private ExcelPackage _package;
        private Closure _callback;
        public Function()
        {}
        public Function(Context ctx, ExcelPackage package, Closure callback)
        {
            _ctx = ctx;
            _package = package;
            _callback = callback;
        }
        public override CompileResult Execute(IEnumerable<FunctionArgument> arguments, ParsingContext context)
        {
            PhpArray args = PhpArray.NewEmpty();
            PhpArray contextArr = PhpArray.NewEmpty();
            PhpValue ret = PhpValue.Null;
            object val = null;
            ExcelDataType dt = ExcelDataType.Empty;
            ret = _callback.__invoke(PhpValue.Create(args), PhpValue.Create(contextArr));
            return CreateResult(val, dt);
        }
    }
}