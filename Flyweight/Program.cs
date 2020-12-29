﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var count = 10_000_000;
            var part1 = count / 3;
            var part2 = part1 * 2;

            //MethodBad(rnd, count, part1, part2);
            MethodGood(rnd, count, part1, part2);

            Console.ReadKey();
        }

        static void MethodGood(Random rnd, int count, int part1, int part2)
        {
            string s1 = "fhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhw fhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhw";

            string s2 = "jugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrj";


            string s3 = "BFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jn BFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jn";

            Good.Tree[] trees = new Good.Tree[count];

            for (int i = 0; i < count; i++)
            {
                if (i <= part1)
                {
                    trees[i] = new Good.Tree(x: rnd.NextDouble(), y: rnd.NextDouble(), "Берёза", Color.White, s1);
                }
                else if (i <= part2)
                {
                    trees[i] = new Good.Tree(x: rnd.NextDouble(), y: rnd.NextDouble(), "Ёлка", Color.Green, s2);
                }
                else
                {
                    trees[i] = new Good.Tree(x: rnd.NextDouble(), y: rnd.NextDouble(), "Сосна", Color.Brown, s3);
                }
            }

            Console.ReadKey();
        }

        static void MethodBad(Random rnd, int count, int part1, int part2)
        {
            string s1 = "fhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhw fhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhwfhfewujgkgbrgrwgu rughwrgrwb wgrwyh gurhguhrwgrwhgrwggrwgiwrgyyhbgybgrywghyhgyuwghruhrugrhw";

            string s2 = "jugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrjjugfjryhgjrjbgrjegl ngrk ol kjgwrj";


            string s3 = "BFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jn BFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jnBFfebwkf jbnflew few*45gj nelgn_ gre gnlgnre blnglreb gkwrl grb. wrgj brw lgrw ngr l egrnl eglj lengl nlngre jn";



            Bad.Tree[] trees = new Bad.Tree[count];

            for (int i = 0; i < count; i++)
            {
                if (i <= part1)
                {
                    trees[i] = new Bad.Tree()
                    {
                        Name = "Берёза",
                        Color = Color.White,
                        X = rnd.NextDouble(),
                        Y = rnd.NextDouble(),
                        Data = s1
                    };
                }
                else if (i <= part2)
                {
                    trees[i] = new Bad.Tree()
                    {
                        Name = "Ёлка",
                        Color = Color.Green,
                        X = rnd.NextDouble(),
                        Y = rnd.NextDouble(),
                        Data = s2
                    };
                }
                else
                {
                    trees[i] = new Bad.Tree()
                    {
                        Name = "Сосна",
                        Color = Color.Brown,
                        X = rnd.NextDouble(),
                        Y = rnd.NextDouble(),
                        Data = s3
                    };
                }
            }

            Console.ReadKey();
        }        
    }
}