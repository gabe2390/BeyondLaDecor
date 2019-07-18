import React from "react";
import { Container } from "native-base";
import { EventCard } from "../components/event-card/event-card.component";
import { Location } from "../models/location.model";
import { User } from "../models/user.model";
import { Package } from "../models/package.model";
import { Task } from "../models/task.model";

export interface EventViewState {
    
}
export class EventView extends React.Component<{}, EventViewState> {
    constructor() {
        super({});
    }
    render() {
        
        return (
            <Container>
                {this.getEvents()}
            </Container>
        );
    }

    getEvents(){
        var events : Event[] = [];
        for (var i : number = 0; i<6; i++){
                events.push(this.getEvent())
        }
        return events.map((event : Event)=> <EventCard event={event} tasks={this.getTasks()}></EventCard>)
    }
    getEvent() : Event {
        let client: User = {
          firstName: "Abe",
          lastName: "Lincoln",
          isAdministrator: false,
          email: "abc@gmail.com",
          userName: "abeLinc09"
      };
      let weddingPackage: Package = {
          packageId: 1,
          capacity: 200,
          isCustom: false,
          name: "Platinum",
          services: [
              {
                  name: "DJ",
                  description: "Disc Jockey",
                  thirdParty: false,
                  serviceId: 1,
                  serviceType: { name: "Media", serviceTypeId: 4 }
              },
              {
                  name: "Photographer",
                  description: "Take pics",
                  thirdParty: true,
                  serviceId: 1,
                  serviceType: { name: "Media", serviceTypeId: 4 }
              }],
          products: [
              {
                  name: "Golden Arches",
                  description: "Golden Son!",
                  productId: 1,
                  thirdParty: false,
                  productType: { name: "CenterPiece", productTypeId: 1 }
              },
              {
                  name: "Purple Arches",
                  description: "Purple Son!",
                  productId: 2,
                  thirdParty: false,
                  productType: { name: "CenterPiece", productTypeId: 1 }
              }
          ]
      };
      let locations: Location[] = [
          {
              name: "Bistro Romanos", locationId: 1, startTime: new Date(251513512351),
              address: "123 Fake Street", city: "Philadelphia", state: "PA", zipCode: "19124"
          }
      ];
        var event : Event =  {
          eventId: 1,
          eventType: { name: "Wedding", eventTypeId: 1 },
          client: client,
          package: weddingPackage,
          date: new Date(),
          locations: locations
        }
        return event;
      }
      getTasks() : Task[] {
        return [
          { taskId: 1, name: "Eat cake", complete: false },
          { taskId: 2, name: "Eat dinner", complete: true }
        ];
      }
}