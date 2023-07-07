const { render, screen, waitForElementToBeRemoved } = require("@testing-library/react");
import userEvent from "@testing-library/user-event";
import { rest } from "msw";
import { setupServer } from "msw/node";
import { Home } from ".";
import { PhotoMockResponse, PostMockResponse } from "./mock";
import { act } from "react-dom/test-utils";

const postsMock = PostMockResponse;
const photoMockResponse = PhotoMockResponse;
const handlers = [
  rest.get("https://jsonplaceholder.typicode.com/posts", async (req, res, ctx) => {
    return res(ctx.json(postsMock));
  }),
  rest.get("https://jsonplaceholder.typicode.com/photos", async (req, res, ctx) => {
    return res(ctx.json(photoMockResponse));
  }),
];

const server = setupServer(...handlers);

describe("<Home />", () => {
  beforeAll(() => {
    server.listen();
  });

  it("should render search, posts and load more", async () => {
    render(<Home />);
    const noMorePosts = screen.getByText("Pesquisa não retornou valor");
    await waitForElementToBeRemoved(noMorePosts);

    expect.assertions(3);

    const search = screen.getByPlaceholderText(/Digite a pesquisa/i);
    expect(search).toBeInTheDocument();

    const images = screen.getAllByRole("img");
    expect(images).toHaveLength(postsMock.length);

    const button = screen.getByRole("button", { name: /Carregar/i });
    expect(button).toBeInTheDocument();
  });

  it("should search for posts", async () => {
    render(<Home />);
    const noMorePosts = screen.getByText("Pesquisa não retornou valor");
    await waitForElementToBeRemoved(noMorePosts);

    expect.assertions(6);

    const search = screen.getByPlaceholderText(/Digite a pesquisa/i);
    expect(search).toBeInTheDocument();

    var postProcurado = screen.getByRole("heading", { name: /qui est esse/i });
    expect(postProcurado).toBeInTheDocument();

    act(() => {
      userEvent.type(search, "ea molestias quasi exercitationem repellat qui ipsa sit aut");
    });

    const postNaoProcurado = postProcurado;
    postProcurado = screen.queryByRole("heading", {
      name: /ea molestias quasi exercitationem repellat qui ipsa sit aut/i,
    });
    expect(postProcurado).toBeInTheDocument();
    expect(postNaoProcurado).not.toBeInTheDocument();

    act(() => {
      userEvent.clear(search);
    });

    postProcurado = screen.getByRole("heading", { name: /qui est esse/i });
    expect(postProcurado).toBeInTheDocument();

    act(() => {
      userEvent.clear(search);
      userEvent.type(search, "texto que não vai ser encontrado");
    });

    const textoDeValidacao = screen.getByText("Pesquisa não retornou valor");
    expect(textoDeValidacao).toBeInTheDocument();
  });

  it("should load more posts on load more", async () => {
    render(<Home />);
    const noMorePosts = screen.getByText("Pesquisa não retornou valor");
    await waitForElementToBeRemoved(noMorePosts);

    expect.assertions(1);

    const button = screen.getByRole("button", { name: /Carregar/i });
    expect(button).toBeDisabled();
  });

  afterEach(() => {
    server.resetHandlers();
  });

  afterAll(() => {
    server.close();
  });
});
