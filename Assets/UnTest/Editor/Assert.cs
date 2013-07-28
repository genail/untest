/*
UnTest Unity3D Unit Testing Framework Copyright (C) 2013 Andrew Fray

This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;

namespace UnTest {
    
public static class Assert {
    

    public static void IsTrue(bool condition) {
        if (condition == false) {
            throw new Exception("Assert failed");
        }
    }

    public static void IsEqual(object lhs, object rhs) {

        if (lhs == null) {
            if (rhs != null) {
                throw new Exception("Fail: " + lhs + " != " + rhs);
            }

        } else if (lhs.Equals(rhs) == false) {
            throw new Exception("Fail: " + lhs + " != " + rhs);
        }
    }
}

}