import { render, screen } from "@testing-library/react";
import { Posts } from ".";
import { PostsMock } from "./mock";

const { posts } = PostsMock;

describe("<Posts />", () => {

    it("should render empty posts list", () => {
        render(<Posts></Posts>)
    });

    it("should render posts", () => {
        render(<Posts posts={posts}></Posts>)

        expect(screen.getAllByRole("heading", { name: /title/i})).toHaveLength(3);
        expect(screen.getAllByRole("presentation", { name: /title/i})).toHaveLength(3);
        expect(screen.getAllByText(/body/i)).toHaveLength(3);
        expect(screen.getByRole("presentation", { name: /title 3/i})).toHaveAttribute("src", "https://in.ign.com/spider-man-ps4/127764/feature/should-you-buy-marvels-spider-man");
    });

    
    it("should match snapshot", () => {
        const {container} = render(<Posts posts={posts}></Posts>)

        expect(container.firstChild).toMatchSnapshot();
    }); 

});