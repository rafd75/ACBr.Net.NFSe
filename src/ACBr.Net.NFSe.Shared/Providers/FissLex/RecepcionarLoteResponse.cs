// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 12-27-2017
//
// Last Modified By : RFTD
// Last Modified On : 12-27-2017
// ***********************************************************************
// <copyright file="ProviderFissLex.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ServiceModel;

namespace ACBr.Net.NFSe.Providers.FissLex
{
    [MessageContract(WrapperName = "WS_RecepcionarLoteRps.ExecuteResponse", WrapperNamespace = "FISS-LEX", IsWrapped = true)]
    internal sealed class RecepcionarLoteResponse
    {
        #region Constructors

        public RecepcionarLoteResponse()
        {
        }

        public RecepcionarLoteResponse(string Enviarloterpsresposta)
        {
            this.Enviarloterpsresposta = Enviarloterpsresposta;
        }

        #endregion Constructors

        #region Properties

        [MessageBodyMember(Namespace = "FISS-LEX", Order = 0)]
        public string Enviarloterpsresposta;

        #endregion Properties
    }
}