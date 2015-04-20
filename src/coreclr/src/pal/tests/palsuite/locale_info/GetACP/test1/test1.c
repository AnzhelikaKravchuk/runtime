//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 
//

/*============================================================================
**
** Source:  test1.c
**
** Purpose: Tests that GetACP returns the expected default code page.
**
**
**==========================================================================*/


#include <palsuite.h>

/* 
 * NOTE: We only support code page 65001 (UTF-8).
 */

#define EXPECTED_CP     65001

int __cdecl main(int argc, char *argv[])
{
    int ret;

    if (PAL_Initialize(argc, argv))
    {
        return FAIL;
    }

    ret = GetACP();
    if (ret != EXPECTED_CP)
    {
        Fail("ERROR: got incorrect result for current ANSI code page!\n"
            "Expected %d, got %d\n", EXPECTED_CP, ret);
    }
    
    PAL_Terminate();
    return PASS;
}

