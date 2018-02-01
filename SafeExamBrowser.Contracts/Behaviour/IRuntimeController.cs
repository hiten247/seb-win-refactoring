﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System.Collections.Generic;
using SafeExamBrowser.Contracts.Behaviour.Operations;

namespace SafeExamBrowser.Contracts.Behaviour
{
	public interface IRuntimeController
	{
		/// <summary>
		/// Reverts any changes, releases all used resources and terminates the runtime.
		/// </summary>
		void Terminate();

		/// <summary>
		/// Tries to start the runtime. Returns <c>true</c> if successful, otherwise <c>false</c>.
		/// </summary>
		bool TryStart(Queue<IOperation> operations);
	}
}