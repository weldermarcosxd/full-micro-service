import { screen, render } from "@testing-library/react";
import { PostCard } from ".";

import { PostCardMock } from "./mock";

const props = PostCardMock;

describe("<PostCard />", () => {
    it("should render PostCard correctly", async () => {
        const {debug} = render(<PostCard {...props} />)
        debug();
        
        const img = await screen.findByRole("img", {name: props.post.title }); 
        expect(img).toBeInTheDocument(); 
    })
});