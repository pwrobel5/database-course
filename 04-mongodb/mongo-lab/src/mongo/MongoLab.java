package mongo;

import java.net.UnknownHostException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.regex.Pattern;

import com.mongodb.*;

public class MongoLab {
	private MongoClient mongoClient;
	private DB db;
	
	public MongoLab() throws UnknownHostException {
		mongoClient = new MongoClient("localhost", 27017);
		db = mongoClient.getDB("mongo_zadanie");
	}
	
	private void showCollections(){
		for(String name : db.getCollectionNames()){
			System.out.println("colname: "+name);
		}
	}

	private void distinctBusinessCities() {
		DBCollection businessCollection = db.getCollection("business");
		for(Object o: businessCollection.distinct("city")) {
			System.out.println(o);
		}
	}

	private void reviewsBetweenYears(int yearFrom, int yearTo) {
		DBCollection reviewCollection = db.getCollection("review");

		Pattern yearFromPattern = Pattern.compile(String.valueOf(yearFrom), Pattern.CASE_INSENSITIVE);
		Pattern yearToPattern = Pattern.compile(String.valueOf(yearTo), Pattern.CASE_INSENSITIVE);

		ArrayList<BasicDBObject> orArgs = new ArrayList<>();
		orArgs.add(new BasicDBObject("date", yearFromPattern));
		orArgs.add(new BasicDBObject("date", yearToPattern));
		BasicDBObject query = new BasicDBObject("$or", orArgs);

		DBCursor result = reviewCollection.find(query);

		try {
			while(result.hasNext()) {
				System.out.println(result.next());
			}
		} finally {
			result.close();
		}
	}

	private void openedBusiness() {
		DBCollection businessConnection = db.getCollection("business");

		BasicDBObject query = new BasicDBObject("open", true);

		DBObject projectionFields = new BasicDBObject("business_id", 1);
		projectionFields.put("name", 1);
		projectionFields.put("full_address", 1);

		DBCursor result = businessConnection.find(query, projectionFields);

		try {
			while(result.hasNext()) {
				System.out.println(result.next());
			}
		} finally {
			result.close();
		}
	}

	private void usersWithPositiveVotes() {
		DBCollection userCollection = db.getCollection("user");

		userCollection.createIndex(new BasicDBObject("name", 1));

		ArrayList<BasicDBObject> orArgs = new ArrayList<>();
		orArgs.add(new BasicDBObject("votes.funny", new BasicDBObject("$gte", 1)));
		orArgs.add(new BasicDBObject("votes.useful", new BasicDBObject("$gte", 1)));
		orArgs.add(new BasicDBObject("votes.cool", new BasicDBObject("$gte", 1)));

		BasicDBObject query = new BasicDBObject("$or", orArgs);
		BasicDBObject sortingOrder = new BasicDBObject("name", 1);

		DBCursor result = userCollection.find(query).sort(sortingOrder);

		try {
			while(result.hasNext()) {
				System.out.println(result.next());
			}
		} finally {
			result.close();
		}
	}

	private void businessTipsNumber(int year) {
		DBCollection businessCollection = db.getCollection("business");
		DBCollection tipCollection = db.getCollection("tip");

		businessCollection.createIndex(new BasicDBObject("name", 1));

		Pattern yearPattern = Pattern.compile(String.valueOf(year), Pattern.CASE_INSENSITIVE);

		DBObject match = new BasicDBObject("$match", new BasicDBObject("date", yearPattern));

		DBObject groupFields = new BasicDBObject("_id", "$business_id");
		groupFields.put("count", new BasicDBObject("$sum", 1));
		DBObject group = new BasicDBObject("$group", groupFields);

		DBObject lookupFields = new BasicDBObject("from", "business");
		lookupFields.put("localField", "_id");
		lookupFields.put("foreignField", "business_id");
		lookupFields.put("as", "B");
		DBObject lookup = new BasicDBObject("$lookup", lookupFields);

		DBObject projectFields = new BasicDBObject("_id", 1);
		projectFields.put("count", 1);
		projectFields.put("B.name", 1);
		DBObject project = new BasicDBObject("$project", projectFields);

		DBObject sort = new BasicDBObject("$sort", new BasicDBObject("B.name", 1));

		List<DBObject> pipeline = Arrays.asList(match, group, lookup, project, sort);
		AggregationOutput output = tipCollection.aggregate(pipeline);

		for(DBObject result: output.results()) {
			System.out.println(result);
		}
	}

	private void businessStars() {
		DBCollection reviewCollection = db.getCollection("review");

		DBObject groupFields = new BasicDBObject("_id", "$business_id");
		groupFields.put("avg_stars", new BasicDBObject("$avg", "$stars"));
		DBObject group = new BasicDBObject("$group", groupFields);

		DBObject sort = new BasicDBObject("$sort", new BasicDBObject("avg_stars", -1));

		DBObject lookupFields = new BasicDBObject("from", "business");
		lookupFields.put("localField", "_id");
		lookupFields.put("foreignField", "business_id");
		lookupFields.put("as", "B");
		DBObject lookup = new BasicDBObject("$lookup", lookupFields);

		List<DBObject> pipeline = Arrays.asList(group, sort, lookup);
		AggregationOutput output = reviewCollection.aggregate(pipeline);

		for(DBObject result: output.results()) {
			System.out.println(result);
		}
	}

	private void deleteBusinessUnderThreshold(double threshold) {
		DBCollection reviewCollection = db.getCollection("review");

		DBObject groupFields = new BasicDBObject("_id", "$business_id");
		groupFields.put("avg_stars", new BasicDBObject("$avg", "$stars"));
		DBObject group = new BasicDBObject("$group", groupFields);

		DBObject match = new BasicDBObject("$match", new BasicDBObject("avg_stars", new BasicDBObject("$lt", threshold)));

		List<DBObject> pipeline = Arrays.asList(group, match);
		AggregationOutput output = reviewCollection.aggregate(pipeline);
		DBCollection businessCollection = db.getCollection("business");

		for(DBObject result: output.results()) {
			businessCollection.remove(new BasicDBObject("business_id", result.get("_id")));
		}
	}

	public static void main(String[] args) throws UnknownHostException {
		MongoLab mongoLab = new MongoLab();
		//mongoLab.showCollections();
		//mongoLab.distinctBusinessCities();
		//mongoLab.reviewsBetweenYears(2011, 2012);
		//mongoLab.openedBusiness();
		//mongoLab.usersWithPositiveVotes();
		//mongoLab.businessTipsNumber(2013);
		//mongoLab.businessStars();
		mongoLab.deleteBusinessUnderThreshold(3.0);
	}

}
