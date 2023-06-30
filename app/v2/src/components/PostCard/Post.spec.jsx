import { screen, render } from "@testing-library/react";
import { PostCard } from ".";

import { PostCardMock } from "./mock";

const props = PostCardMock;

describe("<PostCard />", () => {
  it("should render PostCard correctly", () => {
    render(<PostCard {...props} />);
    const img = screen.getByRole("img", { name: /title 1/i });
    const heading = screen.getByRole("heading", { name: /title 1/i });
    const paragraph = screen.getByText("body 1");
    expect(img).toHaveAttribute("src", props.post.cover);
    expect(img).toBeInTheDocument();
    expect(heading).toBeInTheDocument();
    expect(paragraph).toBeInTheDocument();
  });

  it("should match snapshot", () => {
    const { container } = render(<PostCard {...props} />);

    expect(container.firstChild).toMatchSnapshot();
  });
});
