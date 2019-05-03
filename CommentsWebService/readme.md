<h1> TO DOs (Increase Scalability) </h1>
<ul>
<li>use WCF to develop a web API, it is more flexbile and structural than ASP.NET MVC or CORE</li>
<li>TCP Binding is faster than http binding, so it will support more users</li>
<li>Not saving the sessions for a connection</li>
<li>One way Messaging if the response is not required (perfect for this scenario)</li>
<h2>Best Approach</h2>
<b>Throttling</b>
<li>Limiting the numbers of concurrent sessions at a single time, this approach saves resources and number of instances at a time</li>
</ul>
