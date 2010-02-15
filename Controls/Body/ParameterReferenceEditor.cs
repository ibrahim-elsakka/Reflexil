/*
    Reflexil .NET assembly editor.
    Copyright (C) 2007-2010 Sebastien LEBRETON

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#region " Imports "
using System.Collections;
using Mono.Cecil;
using Reflexil.Wrappers;
#endregion

namespace Reflexil.Editors
{
    class ParameterReferenceEditor : BaseParameterReferenceEditor
	{
        public ParameterReferenceEditor() : base()
        {
        }

        public ParameterReferenceEditor(ICollection referenceditems) : base(referenceditems)
		{
		}
	}

    #region " VS Designer generic support "
    public class BaseParameterReferenceEditor : GenericOperandReferenceEditor<ParameterDefinition, ParameterWrapper>
    {
        public BaseParameterReferenceEditor()
            : base()
        {
        }
        public BaseParameterReferenceEditor(ICollection referenceditems)
            : base(referenceditems)
        {
        }
    }
    #endregion
}
