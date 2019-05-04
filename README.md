<h1>### ASP.NET MVC WEB API</h1>

The project is simple <b>Web API </b>to support listing, adding and Deleting of comments.

<h2>### How to Run (Using Code First Approach)</h2>

<ul>
<li>Clone the project to a desired folder on the local machine using <b>git clone https://github.com/adarshsharmacvs/DotNetMvcApi.git</b> or if you don't want to clone is open Visual Studio 2017 and <b>File >  New Repository > Clone : </b> paste <b>https://github.com/adarshsharmacvs/DotNetMvcApi.git</b></li>

<li>
Once the project is set up, we need to set up the database, to do so, open the Model folder and open the <b>.edmx</b> file and inside the file right click and click <b> Generate Database from Model </b>
</li>

<li>Run the generated query inside your MSSQL database (You might want to change the connection string first, inside the web.config file for connecting to your own SQL Server)</li>

<li>Once the database is all set, build the project</li>

<li>If there are no build errors run the project</li>
<li>The project will run on your localhost where you might want to go to the comments listings page (GET Request), so at the end of the url add <b>/comments</b></li>
<li>Once you are at the comments page, everything will be on the click of the link (Adding, deleting and listing of comments )</li>
</ul>

<h2>###Using Swagger</h2>
The project has also implemented the swagger, to use the swagger just append <b>/swagger</b> at the end of the url and you will be good to go

<h2>### Pagination</h2>
The listing of the comments is restrited for 5 comments per page only, if the blogsite has more than 5 comments than to see the 6th comment page 2 should be accessed, to go to page 2 append this to the url : <b> ?page=1 </b> <br/> page number starts from 0, to to access page 2 enter <b>?page=1</b> and so on.

<h1>### Developer Manual (Best Practices)</h1>
<ul>
<li>For creating a ASP.NET WEB API project, we should try to avoid the WEB API framework and use the MVC framework only, if we select WEB API then a bunch of unnecessary files and folders are created</li>

<li> Using try Catch where the probability of getting an error is more</li>

<li>Using DisplayName attribute over the model property to change the display name of the model</li>
</ul>

<h2>### To Do (Make the API More scalable)</h2>
<ul>
<li>Implementing
<b>LAZY LOADING </b> rather than <b>Eager Loading</b>
</li>
<li>Using Optimizer to find out if the queries/stored procedures/functions could be improved by some means, for example using <b>Clustered or non clustered index</b> on any column </li>
<li>If the number of records are very large than using <b>hash table</b> as they are faster than <b>temp table</b> for retrieving the records and using temp table where more insertion and data access is required. </li>
<li>Using<b> WCF</b> application to develop a WEB API provides more flexibility and scalability options than ASP.NET or ASP.NET Core web API, as we could switch from HTTP binding to TCP binding which is faster, implement a one way communication if the response is not crucial and use of throttling to limit the number of session at a time.</li>
<li>Use of <b>ASYNC AWAIT</b> and microservices improves the performace</li>
<li>Enhancing EF implementation by removing .toList() if not required and using .AsNoTracking (Lazy Loading Concept).</li>
<li>Pagination, filtering and searching also has a positive impact on the performance.</li>
</ul>
