using System;
using System.Collections.Generic;
using Pchp.Core;
using Pchp.Library;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using OfficeOpenXml.FormulaParsing.ExpressionGraph;
using ExcelDataType = OfficeOpenXml.FormulaParsing.ExpressionGraph.DataType;

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
            try
            {
                ret = _callback.__invoke(PhpValue.Create(args), PhpValue.Create(contextArr));
                if (ret.IsInteger())
                {
                    val = ret.ToLong();
                    dt = ExcelDataType.Integer;
                }
                else if (ret.ToStringOrNull() != null)
                {
                    val = ret.ToString(_ctx);
                    dt = ExcelDataType.String;
                }
                else if (ret.IsDouble())
                {
                    val = ret.ToDouble();
                    dt = ExcelDataType.Decimal;
                }
                else if (ret.IsBoolean)
                {
                    val = ret.ToBoolean();
                    dt = ExcelDataType.Boolean;
                }
                # warning TODO
                // else if (ret.IsObject && ret.Object is Range)
                // {
                // }
            } catch {
                val = null;
                dt = ExcelDataType.ExcelError;
            }
            return CreateResult(val, dt);
        }
    }
}