﻿using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SquareRootOperation : BaseOperation
    {
        public SquareRootOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.SquareRoot(); 
        }
    }
}
