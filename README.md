# Rent A Car Project - Backend

<div id="user-content-setup">
<h1><a id="user-content-setup" class="anchor" aria-hidden="true" href="#setup"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Setup</h1>
<p>After downloading the files and opening the solution u need to do the required and optional configurations.</p>
<ul>
<li>Required</li>
</ul>
<ol>
<li>Creating sql tables </li>
<li>Configure connection string from: DataAccess &gt; Concrete &gt; EntityFramework &gt; <a href="https://github.com/gnc5334/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/RentCarContext.cs">RentCarContext.cs</a> (default configuration for Mssql)</li>
</ol>
<ul>
<li>Replace the server name with yours.</li>
<li>Optional</li>
</ul>
<ol start="3">
<li>Authorization token configurations are held in WebApi &gt; <a href="https://github.com/gnc5334/ReCapProject/tree/master/WebAPI/appsettings.json">appsettings.json</a> &gt; TokenOptions.
<ul>
<li>You can change token options as you wish.</li>
</ul>
</li>
<li>Start the project</li>
</ol>
</div>

<div id="user-content-technologies">
<h1><a id="user-content-technologies-used" class="anchor" aria-hidden="true" href="#technologies-used"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Technologies Used</h1>
<ul>
<li>.NET</li>
<li>ASP.NET for Restful api</li>
<li>EntityFramework Core</li>
<li>Autofac</li>
<li>FluentValidation</li>
<li>MsSql</li>
<li><a href="https://github.com/gnc5334/RentCar-frontend">Angular for Frontend</a></li>
</ul>
</div>

<div id="user-content-techniques">
<h1><a id="user-content-techniques" class="anchor" aria-hidden="true" href="#techniques"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Techniques</h1>
<ul>
<li>Layered Architecture Design Pattern</li>
<li>AOP</li>
<li>JWT</li>
<li>Autofac dependency resolver</li>
<li>IOC</li>
</ul>
</div>
