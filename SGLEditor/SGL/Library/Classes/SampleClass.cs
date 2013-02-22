//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;
using SGL.Storyboard.Generators.Sound;

namespace SGL.Library.Classes
{
    class SampleClass : AbstractClass
    {
        private SampleGenerator generator;
        private int time;
        private String layer;
        private String filepath;
        private int volume;

        // used for class registration
        public SampleClass()
        {
        }

        public SampleClass(int time, String layer, String filepath, int volume)
        {
            this.time = time;
            this.layer = layer;
            this.filepath = filepath;
            this.volume = volume;
            InitializiseSampleGenerator();
        }

        public override string Name
        {
            get { return "Sample"; }
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            throw new CompilerException(-1, 314, Name, name);
        }

        private void InitializiseSampleGenerator()
        {
            generator = new SampleGenerator(time, layer, filepath, volume);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterStoryboardGenerator(generator);
        }

        public override object CreateInstance(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.Integer, ValType.Layer, ValType.String, ValType.Integer))
                return new SampleClass(param[0].IntValue, param[1].StringValue, param[2].StringValue, param[3].IntValue);
            else throw new CompilerException(-1, 312);
        }

    }
}
