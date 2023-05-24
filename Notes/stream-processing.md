# Stream Processing

## Stateless Stream Processors
### Filtering
Should a message (Event) be processed in some way? e.g. turned into a command.
#### Content/Context-Based Filtering
An event might need processed in different ways based on content or context. E.g. firing an employee might be implemented differently depending on who is producing the event.
### Splitter
An event might need several commands.

### Preprocessing
Embellishing, Removing

### Alerts 

When a condition is met, some other needs notified. these often need to be stateful.


## Stateful Stream Processors
### Aggregation

#### Merging / Joining

- Correlation - Some things are the culmination of many events, and those events might be on different topics.

* Detecting Temporal Event Sequence Patterns - login attempts from various devices, fraud, 



"Over time", or "within a time" (windowed).
- A customer that places more than 5 orders in a month gets free shipping for 30 days.
- A salesperson that sells enough of product A gets a steak knife set, product B gets a vacation, but you have to sell something to get coffee. Coffee is for closers!
- When the complete set of events for producing an insurance quote are accumulated, a quote can be produced.
	- A quote plus a premium payment can become a policy.
- A quote that hasn't been converted in X number of days/hours is now a "dangling" quote.
	- Anyone interested in these? Here's a topic to subscribe to!


## Bridges
(My term)

Thinking of something like [[Kafka Connect]]  [Sinks and Source](https://docs.confluent.io/platform/current/connect/index.html#how-kafka-connect-works)

### Source 
Injects data from a database or whatever and produces a stream in a topic or topics for that data.

### Sink
Delivers data from a topic directly into a secondary source
