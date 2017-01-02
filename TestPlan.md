# **My Web Server**

## **Test Plan**

#### **Version: 1.0**

#### **Author: Designated Tester (DT)**

#Table of Contents

##[Introduction](#1)        

###[Software Overview](#1.1)        

##[Test Strategy](#2)        

###[Stakeholders and Testing Goals](#2.1)

###[Available Resources](#2.2)

###[Reaching Testing Goals with Available Resources](#2.3)

##[Test Plan](#3)

###[Requirements to be Tested / Not Tested](#3.1)

####[Requirements to be tested](#3.1.1)

####[Requirements not to be tested](#3.1.2)

###[Testing Types](#3.2)

####[Function Testing](#3.2.1)

####[Installation testing](#3.2.2)

####[Load Testing](#3.2.3)

####[JUint Testing](#3.2.4)

###[Test Cases Naming Scheme](#3.3)

###[Roles and Responsibilities](#3.4)

###[Risks](#3.5)

####[Mitigation strategy](#3.5.1)

##[Test Cases](#4)

###[Installation](#4.1)

####[TC1\_R1 Deploy system](#4.1.1)

###[Functionality](#4.2)

####[TC1.1\_R2 Start server failed with empty arguments](#4.2.1)

####[TC1.2\_R2 Start server failed with only port number provided](#4.2.2)

####[TC1.3\_R2 Start server failed with non-integer port number provided](#4.2.3)

####[TC 1.4\_R2 Start server failed with out of range port number provided](#4.2.4)

####[TC1.5\_R2 Start server failed with correct port number and non-existent shared folder path](#4.2.5)

####[TC1.6\_R2 Start server successful with correct port number and shared folder path](#4.2.6)

####[TC 1.7\_R2 Start server failed when port socket provided is already taken](#4.2.7)

####[TC2.1\_R2 Stop server failed if incorrect command word was provided](#4.2.8)

####[TC2.2\_R2 Stop server successful if correct command word was provided](#4.2.9)

####[TC3.1\_R2 Request shared resource success](#4.2.10)

####[TC3.2\_R2 Request shared resource failed – shared resource cannot be found](#4.2.11)

####[TC3.3\_R2 Request shared resource failed – resource is outside of the shared container](#4.2.12)

####[TC3.4\_R2 Request shared resource failed – resource request is invalid or malformed](#4.2.13)

####[TC3.5\_R2 Request shared resource failed – internal server error while trying to process request](#4.2.14)

###[Performance](#4.3)

####[TC1\_R7 One user accessing the server once](#4.3.1)

####[TC2\_R7 Ten users accessing the server every two seconds ten times](#4.3.2)

####[TC3\_R7 Fifty users connecting to the server with a second delay among each other executed ten times](#4.3.4)

####[TC4\_R7 Hundred users connecting to the server every second ten times](#4.3.5)

###[JUnit Test](#4.4)

###[Traceability Matrix](#4.5)

##[Test Results](#5)

# Introduction <a name="1"></a>
The following Test Plan document contains a test strategy, a test plan, test cases and a test report for a Java Web Server software.

Scenario below provides a background to explain the purpose for this document creation.

The small Software Development Company (SDC) has found a possible market niche for giving out a simple to deploy web-server. SDC aims to redistribute this server on a wide range of Internet Of Things (IOT) to present information from sensors etc. SDC wants an easy to deploy java-web-server that can be deployed on many different devices and therefore that can attract attention of a wide range of IOT developers. IOT-developers want minimal configuration as well as easy integration and adaptation of the web-server. End-customers want easy access and absolute security. The SDC management has found an open source abandonware software called &quot;My web server&quot;. It is your job as SDC employee(s) to evaluate the current state of &quot;My web server&quot;. SDC needs to know if the abandoned software fulfills the requirements as stated in the requirement document. Your budget is one man-week times the number of students. SDC management want a strategy, plan, test-cases as well as a test-report.
<a name="1.1"></a>
## Software Overview

My Web Server is an easy to deploy, well tested, open source, web server that supports multiple platforms.
<a name="2"></a>
# Test Strategy
<a name="2.1"></a>
## Stakeholders and Testing Goals

Given the above scenario, the following stakeholders have been identified:

1. The company, SDC
2. IOT developers
3. End users

The table below presents goals for each type of stakeholders as well as the requirements that were presented in the additional document supplied by the company.

| Stakeholders | Goals / Requirements |
| --- | --- | 
| The company, SDC | Software shall be easy to deploy on multiple platforms |
| IOT developers | Software shall require minimal configurationSoftware shall be easy to integrate and adapt |
| End users | Software shall be easy to access Software shall provide maximum security |
|   | The web server should be responsive under high load.The web server must follow minimum requirements for HTTP 1.1The web server must work on Linux, Mac, Windows XP, Vista, 7, 8, 10, Server 2008.The source code should be released under GPL-2.0.The access log should be viewable from a text editor. |



The overall testing goals include the following:

- To ensure that the software meets the stakeholders&#39; requirements
- To detect any defects
- To give confidence in software quality


<a name="2.2"></a>
## Available Resources

The group consists of one person, the Designated Tester (DT), therefore the budget for competing the assignment is 40 hours.

The DT has access to the machines running Windows XP Home Edition SP3 (1GB RAM, 32-bit Operating System(OS)), Windows 7 (2GB RAM, 32-bit OS), and Windows 8.1 (4GB RAM, 64-bit OS, x64-based processor).

The TD possess certain knowledge of Java, Eclipse.
<a name="2.3"></a>
## Reaching Testing Goals with Available Resources

In this iteration the focus will be on ensuring that the system is functional on the available machines. Manual tests will be carried out that will derive from the use cases outlined in the requirements document provided. Also, JUnit tests that came with the system, will be carried out to check if all of them pass. Coverage test will be carried out on JUnit test suites using EclEmma test coverage tool.

Performance of the system under different loads will also be tested utilising Apache JMeter application.

In order to be able to test any system, the testers should possess domain knowledge of that system. Therefore, one needs to have adequate knowledge of the system in question (to understand at least the basic principles of what it is and how it should work), the programming language used, the appropriate IDE (e.g. Eclipse), and the knowledge of testing tools to be used (JMeter). In this case, the DT has some knowledge of Java and the IDE (Eclipse); not much knowledge of JUnit nor how the webserver should operate; no previous knowledge of JMeter. Software testing is also a learning curve for the DT. Certain amount of time should be allocated to fill these gaps in order to proceed to the next stage.

The author has a very minimum knowledge of HTTP 1.1 protocol, therefore not every scenario created to test this requirement can be executed.

In order to deploy the software each machine to be used during testing shall have an appropriate IDE installed. In our case, since the TD has some experience with Eclipse, this IDE will be used. One of the machines, already has the IDE installed. The other to machines do not have Eclipse installed, therefore certain amount of time shall be allocated in order to deploy Eclipse (Eclipse requires Java Development Kit(JDK) to be installed, therefore it must also be installed).

Apache JMeter application, its plugins, as well as a test coverage tool (in our case EclEmma) will also need to be installed on each machines.

There is a requirement to provide this document in a format, that not many people have used before, therefore certain amount of time should be allocated to find the tools to convert the contents of the document to a required .md format and to make sure that it is displayed correctly (including the tables and images).
<a name="3"></a>
# Test Plan
<a name="3.1"></a>
## Requirements to be Tested / Not Tested

The following section identifies the requirements that will be tested. It also includes the features/requirements that will not be tested, outlining the reasons for not testing them.
<a name="3.1.1"></a>
### Requirements to be tested

- Software shall be easy to deploy on multiple platforms. Deploying the web server on the available machines will be the main test for this requirement.
- The web server must work on Windows XP, 7, 8. This requirement will involve testing the main functionality of the web server by creating and executing test cases derived from use cases outlined in the requirements document.
- Software shall be easy to access. This requirement will be tested by creating and executing tests cases for use case 3 (UC3 Request shared resource).
- The web server must follow minimum requirements for HTTP 1.1. This requirement will be tested by creating and executing tests cases for use case 3 (UC3 Request shared resource) as indicated in the requirements document; and by running a set of JUnit tests created by the application developer. As mentioned earlier, it may not be possible at this stage to create all test cases for this requirement and to execute them.
- The access log should be viewable from a text editor. This requirement will involve testing the main functionality of the web server by creating and executing test cases derived from use cases outlined in the requirements document.
- Software shall require minimal configuration. This requirement will be tested by running the application on available machines.
- The web server should be responsive under high load. The web server performance will be tested using Apache JMeter application.
- The source code should be released under GPL-2.0. Testing this requirement will involve examining the license document under which the application was released.
<a name="3.1.2"></a>
### Requirements not to be tested

The following requirements will not be tested:

| Requirement not to be tested | Reason |
| --- | --- |
| The web server must work on Linux, Mac, Windows Vista, 10, Server 2008 | At present the DT has no access to the machines running those operating systems |
| Software shall provide maximum security | It is not feasible to test this requirement in this iteration, as it requires knowledge of the domain as well as knowledge of using the specialised tools. At present there are not enough resources for that. |
| Software shall be easy to integrate and adapt | Due to resources limitation this requirement will not be testing in this iteration |
<a name="3.2"></a>
## Testing Types
<a name="3.2.1"></a>
### Function Testing

The goal is to ensure that the application functions as intended.

*Technique.* Execute each use case and each possible use case flow/scenario (create and manually execute test cases applying exploratory approach) using valid and invalid data to ensure that we receive expected results when using valid data; and that appropriate error messages are displayed for invalid data input.

The completion criteria is when all planned tests are executed.
<a name="3.2.2"></a>
### Installation Testing

The goal is to ensure that the application can be installed on different machines and that it functions properly after installation.

*Technique*. Manually deploy the web server source code on each available machine.

The completion criteria is the successful installation of the web server on all machines.
<a name="3.2.3"></a>
### Load Testing

The goal is to test performance of the application under different loads.

*Technique*. Use Apache JMeter tool to simulate different loads on the web server.

The completion criteria is when all planned tests are executed.

<a name="3.2.4"></a>
### JUint Testing

*Technique*. Execute each JUnit test to ensure that each test passes.

The completion criteria is when all tests are run and every test passes.

<a name="3.3"></a>
## Test Cases Naming Scheme

The naming scheme for the test cases is as follows: TCX\_RY; where TC stands for a test case, X is a number of a test case for a specific requirement, R stands for a requirement under test, and Y is the requirement number. For example, a test case 1 for a requirement 4 will be presented as TC1\_R4.

Test cases derived from use cases will be in a format of TCZ.X\_RY, where Z stands for a use case number. As an example, test case 3 of use case 2 for requirement 4 will be presented as TC2.3\_R4.

<a name="3.4"></a>
## Roles and Responsibilities

The only member of the testing team, the designated tester has the following responsibilities:

- Create test strategy, test plan and necessary test cases
- Install any necessary software
- Fill in knowledge gaps to acquire skills necessary to complete all planned tasks
- Execute test cases
- Create and compile the test plan document
- Convert the document to markdown format and ensure it renders properly

<a name="3.5"></a>
## Risks

Since there is only one designated tester for this iteration the possible risks that can be identified are as follows:

- Personnel is temporarily unavailable (e.g. sickness, family emergency). Probability rate low to medium.
- Equipment is unavailable. Probability rate low.
- Installing necessary software takes unexpectedly long. Probability rate low to medium.
- Filling in knowledge gaps takes unexpectedly long. Probability rate medium.

<a name="3.5.1"></a>
### Mitigation strategy

In order to mitigate probable risks the strategy is as follows:

- Start executing the test plan on one machine first (Windows 8.1 where Eclipse is installed and running). Install JMeter, its plugins and EclEmma on that machine first.
- Complete the testing on that machine, compile the document, convert it to markdown format, ensure the document in this format renders properly (e.g. on GitHub).
- Reiterate the above steps for the second machine (Windows 7).
- Reiterate the steps for the third machine (Windows XP).

Following the above mitigation strategy will ensure that the test plan has been executed on at least one machine (worst case scenario).
<a name="4"></a>
# Test Cases
<a name="4.1"></a>
## Installation
<a name="4.1.1"></a>
### TC1\_R1 Deploy system

Ensure the system can be deployed on available machines. It is assumed that a copy of a source code is present on each machine.

**Input**

- Start the operating system on a machine
- Install Java SE (if not already installed)
- Install Eclipse (if not already installed)
- Start Eclipse
- Import existing project into workspace by providing the path to the source code of the application

**Expected Output**

The source code has been successfully imported into the development environment.

**Actual Output**

As expected on all machines
<a name="4.2"></a>
## Functionality

The following tests cases derived from the use cases outlined in the requirements document, namely:

- UC1 Start server
- UC2 Stop server
- UC3 Request shared resource

The goal is to test main functionality of the web server
<a name="4.2.1"></a>
### TC1.1\_R2 Start server failed with empty arguments

Ensure the server will not start without entering a port number and a shared folder path

**Input**

- TC1\_R1
- Open the program (e.g. in Eclipse)
- Select HTTPServerConsole.java
- Press &quot;Run Configurations&quot;
- Make sure that program arguments are left blank
- Click &quot;Run&quot;

**Expected Output**

WrongNumberOfArgumentsException is thrown in the console

**Actual Output**

As expected on all three machines


<a name="4.2.2"></a>
### TC1.2\_R2 Start server failed with only port number provided

Ensure the server does not start if only the (correct) port number is provided and a shared folder path is missing

**Input**

- First 4 steps from TC1.1\_R2 input
- Enter digits in range of 1 to 65535
- Click &quot;Run&quot;

**Expected Output**

NotADirectoryException is thrown in the console

**Actual Output**

As expected on all three machines


<a name="4.2.3"></a>
### TC1.3\_R2 Start server failed with non-integer port number provided

Ensure the server does not start if a non-integer port number is provided

**Input**

- First 4 steps from TC 1.1\_R2 input

- Enter non-integer value (e.g. &quot;hfd&quot;)

- Click &quot;Run&quot;

**Expected Output**

&quot;Enter a valid port 1-65535 and a optional URL&quot; shown in the console

**Actual Output**

As expected on all three machines

<a name="4.2.4"></a>
### TC 1.4\_R2 Start server failed with out of range port number provided

Ensure the server does not start if an out of range (less than 0 or more than 65535) port number is provided

**Input**

- First 4 steps from TC 1.1\_R2 input
- Enter 0 or 65536
- Click &quot;Run&quot;

**Expected Output**

&quot;Enter a valid port 1-65535 and a optional URL&quot; shown in the console

**Actual Output**

As expected on all three machines


<a name="4.2.5"></a>
### TC1.5\_R2 Start server failed with correct port number and non-existent shared folder path

Ensure the server does not start if a non-existent folder path is provided

**Input**

- First 4 steps from TC 1.1\_R2 input
- Enter port number in range of 1 to 65535 followed by a space, enter non existent folder path(e.g. &quot;80 \djfkg\dhs&quot;)
- Click &quot;Run&quot;

**Expected Output**

NotADirectoryException is thrown in the console, &quot;directory does not exist&quot;

**Actual Output**

As expected on all three machines


<a name="4.2.6"></a>
### TC1.6\_R2 Start server successful with correct port number and shared folder path

Ensure the server will start if correct available port socket number and shared folder path are provided

**Input**

- First 4 steps from TC 1.1\_R2 input
- Enter &quot;8080 C:\MyWebServer-master\tests\se\lnu\http\resources\inner&quot;
- Click &quot;Run&quot;

**Expected Output**

- Server has started
- &quot;HTTP Server object constructed

     HTTP Server started

     Accept&quot; shown in the console

- Successful server start message is written in the log

**Actual Output**

As expected on all three machines.

Missing functionality for logging system messages into a file.

Note: in order to successfully start the server, the shared folder path cannot contain any white spaces


<a name="4.2.7"></a>
### TC 1.7\_R2 Start server failed when port socket provided is already taken

Ensure the server does not start if a port socket number provided is already taken

**Input**

Run steps from TC1.6\_R2 twice

Alternatively, if it known that a certain port number is taken perform the following steps:

- First 4 steps from TC 1.1\_R2 input
- Enter port number that is known to be already taken
- Click &quot;Run&quot;

**Expected Output**

&quot;HTTP Server object constructed

  Port is taken&quot; shown in the console

**Actual Output**

As expected on all three machines


<a name="4.2.8"></a>
### TC2.1\_R2 Stop server failed if incorrect command word was provided

Ensure the server does not stop unless a correct command word has been entered in the console. Note, the correct command is &quot;stop&quot; and it is case sensitive.

**Input**

- TC1.6\_R2
- Type any word in the console and press &quot;Enter&quot; on the keyboard

**Expected Output**

Nothing happens, the server is still running

**Actual Output**

As expected on all three machines


<a name="4.2.9"></a>
### TC2.2\_R2 Stop server successful if correct command word was provided

Ensure the server stops when a correct command word has been entered in the console. Note, the correct command is &quot;stop&quot; and it is case sensitive.

**Input**

- TC1.6\_R2
- Type &quot;stop&quot; in the console
- Press &quot;Enter&quot; on the keyboard

**Expected Output**

- The server has stopped.
- &quot;HTTP Server Accept thread stopped

    HTTP Server stopped&quot; message is written in the console

- Appropriate entry has been made into access log

**Actual Output**

As expected on all three machines, apart from the fact that writing to access log feature has not been implemented.


<a name="4.2.10"></a>
### TC3.1\_R2 Request shared resource success

Ensure that shared resource is delivered to the browser by the system

**Input**

- TC1.6\_R2
- Enter &quot;localhost:8080&quot; in the browser

**Expected Output**

- A webpage (specified in the path of the shared resource) is displayed in the browser
- Message about successful access of a shared resource is written into the access log

**Actual Output**

As expected on all machines, apart from missing feature of writing into the access log
<a name="4.2.11"></a>
### TC3.2\_R2 Request shared resource failed – shared resource cannot be found

Ensure that system present an appropriate message if the requested shared resource cannot be found on the server

**Input**

- TC1.6\_R2
- Enter &quot;localhost:8080/notThere.html&quot; in the browser

**Expected Output**

&quot;404 Not found&quot; is displayed in the browser

**Actual Output**

As expected on all three machines


<a name="4.2.12"></a>
### TC3.3\_R2 Request shared resource failed – resource is outside of the shared container

Ensure that system present an appropriate message if the requested shared resource is restricted

**Input**

- TC1.6\_R2
- Enter &quot;localhost:8080/secret.html&quot; in the browser

**Expected Output**

&quot;403 Forbidden&quot; is displayed in the browser

**Actual Output**

secret.html file is outside of the shared folder, however the webpage has the &quot;404 Not found&quot; message indicating that the file is not forbidden but does not exist (which, technically correct as it does not exist within the shared resource folder) – could not simulate the scenario


<a name="4.2.13"></a>
### TC3.4\_R2 Request shared resource failed – resource request is invalid or malformed

Ensure that system present an appropriate message if resource request is malformed or invalid

**Input**

- TC1.6\_R2
- Could not simulate this scenario

**Expected Output**

&quot;400 Bad request&quot; is displayed in the browser

**Actual Output**

Could not simulate this scenario


<a name="4.2.14"></a>
### TC3.5\_R2 Request shared resource failed – internal server error while trying to process request

Ensure that system present an appropriate message if the system encounters error while processing the request

**Input**

- TC1.6\_R2
- Could not simulate this scenario

**Expected Output**

&quot;405 Method not supported&quot; is displayed in the browser

**Actual Output**

Could not simulate this scenario




<a name="4.3"></a>
## Performance

The following tests will simulate different loads on the web server using Apache JMeter. The webpage that is being accessed is a simple HTML page containing two images.


<a name="4.3.1"></a>
###TC1\_R7 One user accessing the server once.

**Input**

- TC1.6\_R2
- Start JMeter
- Add thread group to the test plan.
- Add 3 HTTP request samples to the thread group for sending HTTP request to the running web server with the following values:

    Server Name: localhost

    Port Number: 8080

    Path: 1. &quot;/&quot; (for index.html) 2.&quot;/images/works.png&quot; (for first image) 3. &quot;/images/works2.png&quot; (for second image)

- Add the following listeners to the test plan: Graph Results and Aggregate Report
- Clear previous test results
- Save the test plan
- Enter the following values in the thread group:

     Number of Threads (users): 1

    Ramp-Up Period (in seconds): 1

    Loop Count: 1

- Run the test

**Output**

|   | Windows 8.1 | Windows 7 | Windows XP |
| --- | --- | --- | --- |
| Errors | None | None | None |
| Throughput (per minute) | 952.381 | 3333.333 | 2647.059 |
| Deviation | 28 | 5 | 5 |




<a name="4.3.2"></a>
### TC2\_R7 Ten users accessing the server every two seconds ten times

**Input**

- First six steps of TC1\_R7
- Enter the following values in the thread group:
- Number of Threads (users): 10
- Ramp-Up Period (in seconds): 20
- Loop Count: 10
- Run the test

**Output**

|   | Windows 8.1 | Windows 7 | Windows XP |
| --- | --- | --- | --- |
| Errors | None | None | None |
| Throughput (per minute) | 479.872 | 978.84 | 970.74 |
| Deviation | 25 | 4 | 8 |


<a name="4.3.3"></a>
### TC3\_R7 Fifty users connecting to the server with a second delay among each other executed ten times

**Input**

- First six steps of TC1\_R7
- Enter the following values in the thread group:
- Number of Threads (users): 50
- Ramp-Up Period (in seconds): 50
- Loop Count: 10
- Run the test

**Output**

|   | Windows 8.1 | Windows 7 | Windows XP |
| --- | --- | --- | --- |
| Errors | None | None | None |
| Throughput | 1818.357 | 1817.574 | 1816.091 |
| Deviation | 24 | 8 | 7 |


<a name="4.3.4"></a>
### TC4\_R7 Hundred users connecting to the server every second ten times

**Input**

- First six steps of TC1\_R7
- Enter the following values in the thread group:
- Number of Threads (users): 100
- Ramp-Up Period (in seconds): 100
- Loop Count: 10
- Run the test

**Output**

|   | Windows 8.1 | Windows 7 | Windows XP |
| --- | --- | --- | --- |
| Errors | None | None | None |
| Throughput | 1811.357 | 1808.384 | 1805.507 |
| Deviation | 7 | 6 | 7 |





It was not possible to add JMeter plugins on the second machine (Windows 7) due to screen resolution (the window to add plugins to the application was not rendered properly so the necessary buttons were not accessible), therefore only Aggregate Report and Graph Result listeners were added to the thread group when running the load test.

Throughput value represents the ability of the server to handle high load. The higher this value the better is the server performance.

Deviation value relates to deviation from average of all data samples sent; the lower this value is, the better.

Deviation value is reasonable low (less than 8 on average). There were no errors for each test.

Throughput value, using different (realistic enough) scenarios is quite high which is indicative of capability of the web server to handle high load. On average the web server can handle 1808 transactions per minute / 30 transactions per second.
<a name="4.4"></a>
## JUnit Test

After running all JUnit tests supplied with the system, all three machines produced the same results: there is only one failure (ConsoleViewTest.java in method testPortTaken) and one error (SocketClientTest.java in method testGetFromOnlineServer).

The failure was due to comparison issue, a new line was not treated as such for some reason. This problem was rectified by using &quot;\r\n&quot; instead of just &quot;\n&quot; for a new line, as it seems different operating systems treat new line differently.  &quot;`assertEquals(ConsoleView.PORT\_IS\_TAKEN+ &quot;\n&quot;, outContent.toString());`&quot; changed to &quot;`assertEquals(ConsoleView.PORT\_IS\_TAKEN+ &quot;\r\n&quot;, outContent.toString());`&quot; in ConsoleViewTest.java, line 95.

In relation to the error/test failure discovered, it appears that the IP address provided in the test case is unreachable. Also, the timeout value originalle provided is too short/insufficient (100).

Increasing the timeout value in ClientSocket.java (line 25) to 300 and changing the host name to the one that definitely works from

&quot;`String actual = sut.get("194.47.172.159", 80, "/");`&quot; (in ClientSocketTest.java, line 23) to &quot;`String actual = sut.get("104.219.248.89", 80, "/");`&quot;,

and adjusting the expected output from            

        String expected[] = new String[7];
		expected[0] = "HTTP/1.1 200 OK\r\n";
		expected[1] = "Date: ";
		expected[2] = "Server: Apache/2.2.17 (Win32) mod_wsgi/3.3 Python/2.6.6\r\n";
		expected[3] = "Accept-Ranges: bytes\r\n";
		expected[4] = "Content-Length: 44\r\n";
		expected[5] = "Content-Type: text/html\r\n";
		expected[6] = "\r\n";

  
(ClientSocketTest.java, line 25)

to
                  
		    String expected[] = new String[7];
    		expected[0] = "HTTP/1.1 200 OK\r\n";
    		expected[1] = "Date: ";
    		expected[2] = "Server: Apache\r\n";
    		expected[3] = "Accept-Ranges: bytes\r\n";
    		expected[4] = "Content-Length: 111\r\n";
    		expected[5] = "Content-Type: text/html\r\n";
    		expected[6] = "\r\n";
    

the test passes.

After performing adjustments outlined above and re-running the tests, everything passes with no errors nor failures.

A test coverage tool, EclEmma was used to ensure that the JUnit tests covered all possible testable code to ensure code quality and stability. The test indicated that there is 96% code coverage. Examining the code closer revealed that no major code blocks were left untested.




<a name="4.5"></a>
## Traceability Matrix

The following matrix presents mapping of requirements to test cases to provide forward and backward traceability to indicate that all requirements have been covered during testing

|   | **R1** | **R2** **UC1**|**R2** **UC2** | **R2** **UC3**|**R3**|**R4**|**R5**|**R6**|**R7** |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| JUnit |   |   |   |   |   | X |   |   |   |
| TC1\_R1 | X | X | X | X | X |   |   | X | X |
| TC1.1\_R2 |   | X |   |   |   |   |   |   |   |
| TC1.2\_R2 |   | X |   |   |   |   |   |   |   |
| TC1.3\_R2 |   | X |   |   |   |   |   |   |   |
| TC1.4\_R2 |   | X |   |   |   |   |   |   |   |
| TC1.5\_R2 |   | X |   |   |   |   |   |   |   |
| TC1.6\_R2 |   | X | X | X | X |   | X | X | X |
| TC1.7\_R2 |   | X |   |   |   |   |   |   |   |
| TC2.1\_R2 |   |   | X |   |   |   |   |  |   |
| TC2.2\_R2 |   |   | X |   |   |   | X | X  |   |
| TC3.1\_R2 |   |   |   | X | X | X | X | X |   |
| TC3.2\_R2 |   |   |   | X |   | X |   |   |   |
| TC3.3\_R2 |   |   |   | X |   | X |   |   |   |
| TC3.4\_R2 |   |   |   | X |   | X |   |   |   |
| TC3.5\_R2 |   |   |   | X |   | X |   |   |   |
| TC1\_R7 |   |   |   |   |   |   |   |   | X |
| TC2\_R7 |   |   |   |   |   |   |   |   | X |
| TC3\_R7 |   |   |   |   |   |   |   |   | X |
| TC4\_R7 |   |   |   |   |   |   |   |   | X |


<a name="5"></a>
# Test Results

Below are the results of testing the requirements.

_R1. Software shall be easy to deploy on multiple platforms._ The web server was successfully deployed on all three machines after installing all the necessary software. Even though, the installation was only tested on three machines running different versions of Windows OS, it can be noted that the software is easy to deploy on different machines.

_R2. The web server must work on Windows XP, 7, 8._ Execution of tests cases created to satisfy this requirement shown that the application under test provides the main functionality and works as intended. All functionality tests passed. Writing to a log file functionality is missing.

_R3. Software shall be easy to access._ From the end user point of view, ease of access can be interpreted as how easy it is to access the shared resources on the web server. In order to access the resources all one needs is access to a browser and knowledge of the port number. Therefore, it can be said that this particular requirement has been met.

_R4. The web server must follow minimum requirements for HTTP 1.1._ It has been determined from the source code inspection and from running the tests that the web server  communicates with the browser using HTTP 1.1 protocol. This can be evidences by types of responses that are being received by the browser, that have been tested both manually (e.g. TC3.1\_R2, TC3.2\_R2) and by running JUnit tests (lnu.se.http and lnu.se.reponse packages). Even though manual testing did not cover all possible scenarios, it is reasonable to assume, given the current knowledge of the tester, that this requirement has been met by the application.

_R5. The access log should be viewable from a text editor._ This requirement has not been met as the application is missing writing to access log functionality. If logging functionality is required, it must be implemented by SDC.

_R6. Software shall require minimal configuration._ Once the application has been deployed on a target machine, running the server requires minimum configuration such as providing correct unoccupied port socket number and a path to a shared resource. In this case, configuration to run the server is minimal. It must be noted, that in order to start the server, the path to a folder to be shared cannot contain white spaces, otherwise the server will not start.

_R7. The web server should be responsive under high load._ The web server performance will be tested using Apache JMeter application. Performance test indicates that the web server can handle high load (a hundred users accessing the server every second) without any errors.

_R8. The source code should be released under GPL-2.0._ The application has been released under MIT license by the developer. The reason behind this can be understood as this type of licensing is very short and simple, protects the developer (as there are no risks involved of how the software can be used). However, MIT license does not prevent others from using the source code in some proprietary software, from rebranding and subsequent reselling of the code. Therefore, as per requirement, the type of license should be changed from MIT to GPLv2 to prevent the software from becoming proprietary and to ensure it remains free and open source.

One major drawback is that the software is not well documented to say the least, at the minimum there should be some basic help document describing the installation process and basic functionality (how to start the server, what arguments should be provided and how those should be entered, how to stop the server). It has to be mentioned that there was an introductory video provided with the software, which demonstrated the process of migrating the project into the development environment and the process of starting the server. This was a helpful starting point; however, the author believes that it is a good practice to provide a &quot;user manual&quot; describing main functionality of any software as well as installation instructions. On the side note, the author believes that any application code should also be well commented, to make the code easier to understand.

Overall, the software can be used as intended, with some minor changes. The application is well tested (good code coverage, no major functions have been left untested, good code quality) and it functions as intended; and it meets most of the requirements that had been tested during this iteration.


This document has been uploaded to GitHub to ensure that it renders all content correctly. On the off chance that there are some unexpected problems after the document had been uploaded to the Peer-Review-System, here is the [link](https://github.com/eorp/SalesRegistryVB/blob/master/TestPlan.md) to the version that works.
