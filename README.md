# SistemPendukungKeputusan
Final project for Decision Support Systems course

This is my final project (Decision Support Systems). It is a simple system to provide decision support in choosing concentration in Information Technology, DTETI UGM, using SAW (Simple Additive Weighting). In 2016, DTETI UGM applies the curriculum 2016. The contents of the curriculum include applying 3 groups of concentration areas ie information systems engineering, software engineering, and computer system engineering. 

This is source code of the software. This code was using  Windows Presentation Foundation (WPF) in Visual Studio 2015. This code still contains some bugs and this code is a mess.

<p>how the system works: </p>

<ul>
<li>Determine the criteria that will be used as a reference in decision making (in SAWMethod.cs)</li>
<li>Specifies each alternative's match rating on each criterion using a simple fuzzy method (in Fuzzy.cs)</li>
<li>Creating a decision matrix based on the criteria then performs the matrix normalization based on the equation that is adjusted to the type of attribute so as to obtain the normalized matrix R. (in Normalization.cs)</li>
<li>The final result is obtained from the ranking process that is the sum of normalized matrix multiplication R with vector weights (weight vector contained in GlobalVariablesClass.cs as VectorBootW variable)</li>
<li>Searched for the greatest value by ranking the value to get the best alternative as a solution (in pHasil.cs)</li>
</ul>

Contributors: Dian Anggriawan Hidayat, Berlianto Yusuf
