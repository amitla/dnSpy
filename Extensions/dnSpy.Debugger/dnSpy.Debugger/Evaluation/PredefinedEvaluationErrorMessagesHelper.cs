﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using dnSpy.Contracts.Debugger.Engine.Evaluation;
using dnSpy.Debugger.Properties;

namespace dnSpy.Debugger.Evaluation {
	static class PredefinedEvaluationErrorMessagesHelper {
		static readonly Dictionary<string, string> toErrorMessage;
		static PredefinedEvaluationErrorMessagesHelper() {
			const int TOTAL_COUNT = 1;
			toErrorMessage = new Dictionary<string, string>(TOTAL_COUNT, StringComparer.Ordinal) {
				{ PredefinedEvaluationErrorMessages.ExpressionCausesSideEffects, dnSpy_Debugger_Resources.ExpressionCausesSideEffectsNoEval },
			};
			Debug.Assert(toErrorMessage.Count == TOTAL_COUNT);
		}

		public static string GetErrorMessage(string error) {
			if (error == null)
				throw new ArgumentNullException(nameof(error));
			if (toErrorMessage.TryGetValue(error, out var msg))
				return msg;
			return error;
		}
	}
}