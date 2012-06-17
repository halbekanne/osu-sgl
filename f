[33mcommit d385e823b86237446eeae9e18e75eb3f758ee7ba[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Sun Jun 17 05:46:55 2012 +0200

    add support for user-defined functions. Logic/design is almost done.

[33mcommit 5133d46532001f51acf0977b92cef9271180e06c[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Wed Jun 13 21:45:11 2012 +0200

    add to Sprite: moveX, moveY, move, scaleVec, color

[33mcommit fa4d3aefe1dc1b9bb8a2b0cd4814e1aadaddada5[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Wed Jun 13 21:00:13 2012 +0200

    'Class methods' added, fading, rotating, scaling

[33mcommit e7b7f0da3270c5ce44c7d5f753af7caeb741b891[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu Jun 7 21:05:44 2012 +0200

    I can create Sprites and soon everything else

[33mcommit ce0039d3e92e027d405085015bb51a4002842756[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu Jun 7 17:38:08 2012 +0200

    somewhat runnable...

[33mcommit cf02c9a6e002d64c96278e69884974b5bf0ee473[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu Jun 7 14:56:20 2012 +0200

    finished modifying all nodes, it's gonna be great

[33mcommit 7ac24deacc4975ff37444f0cdd6f4529a75dd984[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Tue Jun 5 22:36:02 2012 +0200

    quick fix

[33mcommit 42bece50ea3f58b3413816f960dc62677f751481[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Tue Jun 5 22:35:32 2012 +0200

    finished modifying operator nodes

[33mcommit f672e09fdb85727448f5d1f907738f8b21f27bad[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Tue Jun 5 22:19:10 2012 +0200

    finished modifying arithmetical operator nodes

[33mcommit 751d675ef8b747a1b51ce38ed0654af0047cb7ad[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu May 31 21:50:39 2012 +0200

    working on the operators

[33mcommit 587981a538e0fcfa339276d031333f574f9d269c[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu May 31 18:22:59 2012 +0200

    git specific changes

[33mcommit 072391d820c6293e184584ca619d9478b84a58c3[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Thu May 31 18:12:42 2012 +0200

    redesigning goes on...

[33mcommit 5d127b193ff6918936669f3f4fe38756faffcb63[m
Author: Dominik Halfkann <dominik.halfkann@googlemail.com>
Date:   Mon May 28 22:39:46 2012 +0200

    current state, full of errors

[33mcommit 8e003a4de82be0f3b7d6983d0d962509f0184021[m
Author: unknown <Dominik Halfkann@Dom-PC.(none)>
Date:   Fri Mar 30 23:07:47 2012 +0200

    Doesn't work right now, but updated to share the current changes. I stared many things from the scratch since they didn't worked out so well.

[33mcommit ff93bb26708ece6b65be2926277ad699b640f741[m
Author: unknown <Dominik Halfkann@Dom-PC.(none)>
Date:   Mon Dec 19 21:30:24 2011 +0100

    Fix bug #8 (Offset in Scopes)
    
    The offset is now recalled from the parent scope at the beginning of a
    block evaluation. If a block is an AT-Block, it simply adds the offset to
    the Blocknode, so that this node can handle offset changes.

[33mcommit 2422b5a4996a3a93a1c316ce2a3f5db328962263[m
Author: unknown <Dominik Halfkann@Dom-PC.(none)>
Date:   Mon Dec 19 20:11:23 2011 +0100

    Add simple on-type error detection for SGL code.
    
    Did some other things too.

[33mcommit d8fa9eda2e71f351d2228494f7fa256eb81991bf[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sat Nov 5 16:05:03 2011 +0100

    Preparation to release a new beta version.
    
    - Change "object" to "Object"
    - Extended the output to fully OSB code
    - Add ability to save, open, create a new document
    - Exception handling with RandomIntegerNode

[33mcommit 9b989a4c6448e99caf50628263856c8753d32701[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Tue Nov 1 01:07:44 2011 +0100

    Add all get<Attribute>() methods avaliable.
    
    Shortly tested as they seem to work.

[33mcommit 48f169ba33c9d7b9e29f1ec68944072c061497df[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Mon Oct 31 18:56:23 2011 +0100

    Calculation of the exact x position on every time and within loops. Fix a bug.
    
    Build a child class of List<> for storyboard commands. Add a feature to add a specified amount of time to every command (for loop calculation e.g.). Implemented osu! easing function (thx peppy) for calculation of attributes. Still need to be completed for other attributes.

[33mcommit c623c7b1d1335736a2e1b17b44cc266c73c21146[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Fri Oct 21 20:02:14 2011 +0200

    Delete unnecessary files.

[33mcommit 1003f38e1521975f48e2df90a89922cd9f14f3fd[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Fri Oct 21 18:42:26 2011 +0200

    Change storyboard command handling to a more object oriented way. Loops seem to work now.
    
    Loops are now handled as commands, with a list of animation objects within. Previous command objects are now SbAnimation objects.
    This will help to shorten the code and should make manipulating commands easier.

[33mcommit cdac37138069b6fca073c56dc2615c25a9ed06c1[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Oct 6 21:38:48 2011 +0200

    Added possibility to get the last attributes, such as last X/Y position. Changed syntax so that object methods can now be called from within expressions. Added exception handling in ObjectMethodNode

[33mcommit 44184efeec49c3ec34ab0581a382903c6b2ceed0[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Wed Oct 5 17:12:06 2011 +0200

    git ignore

[33mcommit 0da71e4bc4043b42906ca77838f909749d4b51d4[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sat Oct 1 00:54:19 2011 +0200

    Changed the way SGL returns storyboard code, last commit was a failure.

[33mcommit 9e875a42746804b79377fb33108011de005259d9[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Fri Sep 30 22:17:18 2011 +0200

    Changed the way SGL added storyboard code, some bugfixes

[33mcommit 63bf1a2f8381d0b91395b5e079299cf60f25ceb1[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Sep 22 23:55:11 2011 +0200

    (experimental) Changed many things, added a new GUI with a SyntaxBox, fixed some bugs, be aware that compiling sb-code doesn't work in this commit

[33mcommit 91d16e71858dab26b7a2f53a3be432bce65e9eda[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:41:49 2011 +0200

    Recovered the sbEditor project

[33mcommit a7fab43472ac8159c0095a69d7c66786fea167b4[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:31:36 2011 +0200

    ... oh man

[33mcommit c55b8e074dc5f01677b408cfcbb473c5694ea55f[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:15:43 2011 +0200

    ...

[33mcommit f1a1c3431549f5df435fd51935b32023392f57f0[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:11:04 2011 +0200

    Revert "Hopefully this commit will fix the mess"
    
    This reverts commit c761017fb4cbe6184efd9e0cc28dc74f67467387.

[33mcommit 034d8116e1f694e6df63d1978239afe69cc03950[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:10:14 2011 +0200

    Revert "Revert "Hopefully this commit will fix the mess""
    
    This reverts commit 2a298ebfd3ef007e68823e3b8cbcc86cf2423603.

[33mcommit 2a298ebfd3ef007e68823e3b8cbcc86cf2423603[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:10:07 2011 +0200

    Revert "Hopefully this commit will fix the mess"
    
    This reverts commit c761017fb4cbe6184efd9e0cc28dc74f67467387.

[33mcommit c761017fb4cbe6184efd9e0cc28dc74f67467387[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 02:07:37 2011 +0200

    Hopefully this commit will fix the mess

[33mcommit 5ebaccfa41ee4e90ce9aa059c60557a455276941[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 01:59:52 2011 +0200

    fixed last commit (removed old files)

[33mcommit f74f8592497405099dfb7ede45a94bfa54c9ccc0[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun Sep 18 01:41:06 2011 +0200

    Added at-blocks, global variables, fixed for-loop, added many objectMethods, cleaned the code, made a Compiler class for easy usage of the SGL compiling process

[33mcommit 9d78eb559fb4f52dc593bdc0aca85d0749cb5e75[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sat Sep 3 22:03:27 2011 +0200

    Added method definition support and break command. Fixed bugs with Blocks and x++ things.

[33mcommit 3fc7f18566142bd4ead448aa43aece62d535040e[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Sep 1 03:10:22 2011 +0200

    Added for-loop and x++ things, also I'm pretty amazed by the speed of the treewalker. Making progress here :)

[33mcommit 3c57d7da4aaff01b70ca3bb03206f679a909443c[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Sep 1 00:01:03 2011 +0200

    Added println, unit tests, some bugfixes

[33mcommit b0071c51e12d5bd87d084de58ff882ad5a2b62fd[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Aug 25 18:36:13 2011 +0200

    Added sb code output interface, along with a sample for the move method with 2 arguments.

[33mcommit 65918b19bd86402979184ec725ffccc5659a36a2[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Aug 18 01:43:21 2011 +0200

    .gitignore

[33mcommit 2b2f6beb6559fe0a04041f4f2579ede9c7636042[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Aug 18 01:34:30 2011 +0200

    .gitignore

[33mcommit 2aa183313c8013f54d398708380346f66b0d7f2c[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Wed Aug 10 19:19:42 2011 +0200

    Added support for variable assignments and if/else/else-if statements. Changed syntax for statements, all statements must end with an ';'

[33mcommit 56a25f64b4e42eac08fe521263db94825ab6c185[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Tue Aug 9 23:01:06 2011 +0200

    Added full variable and expression support, including integer, float, boolean and string.

[33mcommit 7ab1d3aa42838d52091ba40934800f1cb8052160[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Tue Aug 9 00:37:31 2011 +0200

    Complete redesign of the treewalker, so that it can handle complex structures like conditions, loops or functions with ease.

[33mcommit 47a7d9b41f3507b43afbc524c286e8d2f615374e[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Fri Jul 8 18:44:23 2011 +0200

    Added Antlr error reporting, time measuring for debugging purposes, subtraction, multiplication, division and brakes for integer, prepared method handling

[33mcommit 41734206f4c43f26ba8d68601566dac4b637225c[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Jul 7 23:30:40 2011 +0200

    Worked on a SGL-Parser, added VariableScope for handling global and local variables, TestParser can parse things like 'int x = 3+2, c=4'

[33mcommit b6563946d4196ef7d434cbd06ffb5ee93ece5287[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Jun 23 23:06:53 2011 +0200

    Completed the find/replace dialog, but does nothing atm - Found a way to create winforms like in Notepad++

[33mcommit 0387f92b115c3b0f9b1010add670105c72290cec[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Thu Jun 23 18:46:19 2011 +0200

    Added Find/Replace Form, but unfinished

[33mcommit 5c0f9c6c54c65d95751eb20b14fc7288129fe67f[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Tue Jun 21 12:23:56 2011 +0200

    Added dialogs for shifting and moving selected Lines (errors)

[33mcommit 4445aad7009773d8a56eee773b842e862b819fc4[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 14:09:26 2011 +0200

    Git Ignore

[33mcommit 4fdbd8959dfae473f933c7f9361d607bb014dc02[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 14:01:10 2011 +0200

    bin / obj removed

[33mcommit 07c8b3917aca4528fd3a00746dc5372d4171da1f[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 13:59:58 2011 +0200

    Release / Debug deleted

[33mcommit 54332a7ed2f1480ac925b41cd2b950cbc915fe89[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 13:58:37 2011 +0200

    useless dir removed

[33mcommit 275ee7f35d3a034c370dbc404bc04597491295db[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 13:52:37 2011 +0200

    initial checkin

[33mcommit 7c1c5c0a76a0a2337b590c20b17892074e76cc5f[m
Author: David Mohl <david.mohl@hotmail.de>
Date:   Sun May 22 12:39:18 2011 +0200

    Readme

[33mcommit 41b0d7f37ae76494b3c8a779fbfc1cab52d7b171[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun May 15 17:46:30 2011 +0200

    Parser can evaluate math expressions and can generate output. Example in SGLParserTestProject

[33mcommit 9f58b5e49f1c691d38807f9ed328bb75471b1de0[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun May 8 19:08:47 2011 +0200

    Added ANTLR parser for variable declarasion and variable assignment

[33mcommit f7ebc7d2b714f1131a2fb866a3eee5dc6bc8a239[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun May 8 19:02:32 2011 +0200

    Added ANTLR parser for variable declarasion and variable assignment

[33mcommit e0f662305f047d3173e7c9c8514cf906a1a2fed0[m
Author: Dominik Halfkann <Dominik.Halfkann@googlemail.com>
Date:   Sun May 8 18:52:28 2011 +0200

    first commit
